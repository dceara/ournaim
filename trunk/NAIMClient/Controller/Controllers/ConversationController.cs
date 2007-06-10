using System;
using System.Collections.Generic;
using System.Text;
using Common.Interfaces;
using Common.Protocol;
using Common.ProtocolEntities;
using System.IO;
using System.Threading;
using Controller.File_Transfer;
using Common;

namespace Controllers
{
    class ConversationController : IConversationController
    {
        #region Private Members

        private IConversationView conversationView;
        
        private string receiverName;
        
        private string currentClientName;

        #endregion

        #region Peer Transfer Handlers

        PeerSenderConnectionHandler senderConnectionHandler = null;
        PeerReceiverConnectionHandler receiverConnectionHandler = null;
        Thread fileTransferSender = null;
        Thread fileTransferReceiver = null;
        //the key is the requested filename and the value is the writeLocation
        bool alreadyRequested = false;
        KeyValuePair<string, string> _lastRequestedFile;
        
        #endregion

        #region IConversationController Members

        public event SendServerMessageEventHandler SendServerMessageEvent;

        private ushort _localPort;
        public ushort LocalPort
        {
            set
            {
                this._localPort = value;
            }
        }
        private IDictionary<int, string> _peerFileList;

        private IDictionary<int, string> _fileList;
        public IDictionary<int, string> FileList
        {
            set
            {
                this._fileList = value;
            }
        }

        public void AddItemToFileList(int id, string filename)
        {
            if (this.senderConnectionHandler != null)
            {
                senderConnectionHandler.addItemToFileListDelegate.Invoke(id, filename);
            }
        }

        public void RemoveItemFromFileList(int id)
        {
            if (this.senderConnectionHandler != null)
            {
                senderConnectionHandler.removeItemFromFileListDelegate(id);
            }
        }

        public void CreatePeerToPeerConnection()
        {
            AMessageData messageData = new ConnectionDataRequestedMessageData(this.currentClientName, this.receiverName);
            Message message = new Message(new MessageHeader(ServiceTypes.CONNECTION_REQ), messageData);
            OnSendServerMessage(message);
        }

        public void CancelFileTransfer()
        {
            if (this.receiverConnectionHandler != null)
            {
                lock (this.receiverConnectionHandler.toCancel)
                {
                    this.receiverConnectionHandler.toCancel.Value = true;
                }
            }
        }

        public IList<string> GetPeerFileList()
        {
            if (this.receiverConnectionHandler != null)
            {
                this._peerFileList = receiverConnectionHandler.fileListDelegate.Invoke();
                IList<string> toReturn = new List<string>();
                foreach (KeyValuePair<int, string> pair in _peerFileList)
                {
                    toReturn.Add(pair.Value);
                }
                return toReturn;
            }
            return null;
        }

        public void OnSendServerMessage(Message message)
        {
            if (SendServerMessageEvent != null)
            {
                SendServerMessageEvent(message);
            }
        }

        public void ReceiveServerMessage(Message message)
        {
            AMessageData messageData = Message.GetMessageData(message);
            switch (message.Header.ServiceType)
            {
                case Common.ServiceTypes.CONNECTION_DATA:
                    StartFileTransferReceiver(((ConnectionDataMessageData)messageData).IpAddress, ((ConnectionDataMessageData)messageData).Port);
                    break;
                case Common.ServiceTypes.CONNECTION_REQ:
                    StartFileTransferSender(((ConnectionDataRequestedMessageData)messageData).SenderUserName);
                    break;
            }
        }

        public void ReceiveTextMessage(TextMessageData messageData)
        {
            conversationView.AddMessage(messageData.Text);
        }

        public void InitialiseController()
        {
        }

        public void InitialiseView(IConversationView view)
        {
            this.conversationView = view;
            view.Initialise(this.receiverName);
            view.CurrentUserName = currentClientName;
            conversationView.CancelFileTransferEvent += new CancelFileTransferEventHandler(conversationView_CancelFileTransferEvent);
            conversationView.CloseEvent += new CloseEventDelegate(conversationView_CloseEvent);
            conversationView.SendMessageEvent += new SendMessageDelegate(conversationView_SendMessageEvent);
            conversationView.StartFileTransferEvent += new StartFileTransferEventHandler(conversationView_StartFileTransferEvent);
            conversationView.ShowView();
        }

        public string ReceiverName
        {
            get
            {
                return receiverName;
            }
            set
            {
                this.receiverName = value;
            }
        }

        public string CurrentClientName
        {
            get
            {
                return this.currentClientName;
            }
            set
            {
                this.currentClientName = value;
            }
        }

        public event DisposeConversationController DisposeConversationControllerEvent;

        public void OnDisposeConversationController(string userName)
        {
            if (DisposeConversationControllerEvent != null)
            {
                DisposeConversationControllerEvent(userName);
            }
        }

        public void CloseView()
        {
            conversationView.CloseView();
        }

        #endregion

        #region ConversationView Event handlers

        void conversationView_CloseEvent()
        {
            OnDisposeConversationController(this.receiverName);
        }

        void conversationView_CancelFileTransferEvent(string filename)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void conversationView_StartFileTransferEvent(string filename,string writeLocation)
        {
            ReceiveFile(filename, writeLocation);
        }

        public void ReceiveFile(string filename, string writeLocation)
        {
            if (receiverConnectionHandler == null)
            {
                AMessageData messageData = new ConnectionDataRequestedMessageData(this.currentClientName, this.receiverName);
                Message message = new Message(new MessageHeader(ServiceTypes.CONNECTION_REQ), messageData);
                OnSendServerMessage(message);
                this._lastRequestedFile = new KeyValuePair<string, string>(filename, writeLocation);
                this.alreadyRequested = true;
            }
            else
            {
                int fileId = -1;
                foreach (KeyValuePair<int, string> pair in _fileList)
                {
                    if (pair.Value == filename)
                    {
                        fileId = pair.Key;
                    }
                }
                if (fileId == -1)
                    return;
                receiverConnectionHandler.receiveFileDelegate.Invoke(writeLocation, fileId);
            }
        }

        void conversationView_SendMessageEvent(string messageText)
        {
            AMessageData messageData = new TextMessageData(this.currentClientName, this.receiverName, messageText);
            Message toSend = new Message(new MessageHeader(Common.ServiceTypes.TEXT), messageData);
            OnSendServerMessage(toSend);
        }
        #endregion

        #region Peer 2 Peer File transfer

        private void StartFileTransferSender(string senderUserName)
        {
            fileTransferSender = new Thread(StartSenderDelegate);
            fileTransferSender.Start(senderUserName);
        }

        void StartSenderDelegate(object parameter)
        {
            if (senderConnectionHandler == null)
            {
                senderConnectionHandler = new PeerSenderConnectionHandler((string)parameter, this._localPort, this._fileList);
                senderConnectionHandler.Run();
            }
        }

        private void StartFileTransferReceiver(string ipAddress, ushort port)
        {
            fileTransferReceiver = new Thread(StartReceiverDelegate);
            fileTransferReceiver.Start(new object[] { ipAddress, port });
            if (this.alreadyRequested ==true)
            {
                int fileId = -1;
                foreach(KeyValuePair<int,string> pair in _fileList)
                {
                    if(pair.Value == _lastRequestedFile.Key)
                    {
                        fileId = pair.Key;
                    }
                }
                if (fileId == -1)
                    return;
                receiverConnectionHandler.receiveFileDelegate.Invoke(_lastRequestedFile.Value, fileId);
                alreadyRequested = false;
            }
        }

        void StartReceiverDelegate(object parameters)
        {
            if (receiverConnectionHandler == null)
            {
                object[] param = (object[])parameters;
                receiverConnectionHandler = new PeerReceiverConnectionHandler((string)(param[0]), (ushort)(param[1]));
                receiverConnectionHandler.Run();
            }
        }

        #endregion

    }
}

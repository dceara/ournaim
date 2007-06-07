using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common.ProtocolEntities;
using System.IO;
using Controller.File_Transfer;

namespace Common.Interfaces
{
    public delegate void DisposeConversationController(string name);

    public interface IConversationController
    {
        event SendServerMessageEventHandler SendServerMessageEvent;

        event DisposeConversationController DisposeConversationControllerEvent;

        string ReceiverName
        {
            get;
            set;
        }

        string CurrentClientName
        {
            get;
            set;
        }

        ushort LocalPort
        {
            set;
        }

        IDictionary<int, string> FileList
        {
            set;
        }

        void AddItemToFileList(int id, string filename);

        void RemoveItemFromFileList(int id);

        IList<string> GetPeerFileList();

        void CancelFileTransfer();

        void ReceiveFile(string filename, string writeLocation);

        void OnSendServerMessage(Message message);

        void OnDisposeConversationController(string userName);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void ReceiveServerMessage(Message message);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void InitialiseView(IConversationView view);

        void InitialiseController();

        void CloseView();

        void ReceiveTextMessage(TextMessageData messagedata);


        /// <summary>
        /// this is called before initiating the first file transfer
        /// </summary>
        void CreatePeerToPeerConnection();
    }

    public delegate void SendServerMessageEventHandler(Message message);
}

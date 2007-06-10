using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;
using Common.ProtocolEntities;
using System.IO;
using Controller.File_Transfer;

namespace Common.Interfaces
{
    #region IConversationController Interface

    #region Delegates
    /// <summary>
    /// This delegate Disposes a Conversation Controller
    /// </summary>
    /// <param name="name">The name of the conversation controller</param>
    public delegate void DisposeConversationController(string name);

    /// <summary>
    /// Sends a message to the server
    /// </summary>
    /// <param name="message">message being sent</param>
    public delegate void SendServerMessageEventHandler(Message message);

    #endregion

    /// <summary>
    /// This should be implemented by Conversation Controllers
    /// </summary>
    public interface IConversationController
    {
        #region Events
        /// <summary>
        /// Is fired to send a message to the server.
        /// </summary>
        event SendServerMessageEventHandler SendServerMessageEvent;

        /// <summary>
        /// Is fired to dispose the current conversation controller
        /// </summary>
        event DisposeConversationController DisposeConversationControllerEvent;

        #endregion

        #region Properties

        /// <summary>
        /// The name of the receiver for this conversation controller
        /// </summary>
        string ReceiverName
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the local user.
        /// </summary>
        string CurrentClientName
        {
            get;
            set;
        }

        /// <summary>
        /// The port on which the current controller listens for peer 2 peer connections
        /// </summary>
        ushort LocalPort
        {
            set;
        }

        /// <summary>
        /// The current file list.
        /// </summary>
        IDictionary<int, string> FileList
        {
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds an item to the file list
        /// </summary>
        /// <param name="id">Id of the added file</param>
        /// <param name="filename">The name of the added file</param>
        void AddItemToFileList(int id, string filename);

        /// <summary>
        /// Removes an entry from the file list
        /// </summary>
        /// <param name="id">The id of the removed item</param>
        void RemoveItemFromFileList(int id);

        /// <summary>
        /// Gets the peer file list.
        /// </summary>
        /// <returns>The peer file list.</returns>
        IList<string> GetPeerFileList();

        /// <summary>
        /// Cancels the current file transfer
        /// </summary>
        void CancelFileTransfer();

        /// <summary>
        /// Requests a specific file from the peer and saves it.
        /// </summary>
        /// <param name="filename">The name of the requested file.</param>
        /// <param name="writeLocation">The location where to save the received file.</param>
        void ReceiveFile(string filename, string writeLocation);

        /// <summary>
        /// Fires the SendServerMessage Event
        /// </summary>
        /// <param name="message">The message being sent</param>
        void OnSendServerMessage(Message message);

        /// <summary>
        /// Fires the DisposeConversationController event
        /// </summary>
        /// <param name="userName">The name of the current controller</param>
        void OnDisposeConversationController(string userName);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void ReceiveServerMessage(Message message);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void InitialiseView(IConversationView view);

        /// <summary>
        /// Initialises the controller. This should be called by the main controller.
        /// </summary>
        void InitialiseController();

        /// <summary>
        /// Closes the view in front of the conversation controller.
        /// </summary>
        void CloseView();

        /// <summary>
        /// Adds a new text message to the conversation.
        /// This is called by the main controller when a text message is received from the current contact.
        /// </summary>
        /// <param name="messagedata"></param>
        void ReceiveTextMessage(TextMessageData messagedata);


        /// <summary>
        /// this is called before initiating the first file transfer
        /// </summary>
        void CreatePeerToPeerConnection();

        #endregion
    }
    #endregion
}

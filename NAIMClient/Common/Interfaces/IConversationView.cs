using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    #region IConversationView Interface

    #region Delegates

    /// <summary>
    /// Sends a message to the controller.
    /// </summary>
    /// <param name="message">Message being sent</param>
    public delegate void SendMessageDelegate(string message);

    /// <summary>
    /// Closes the view.
    /// </summary>
    public delegate void CloseEventDelegate();

    #endregion

    /// <summary>
    /// This should be implemented by all the conversation views
    /// </summary>
    public interface IConversationView
    {
        #region Events

        /// <summary>
        /// This is fired to send a message to the conversation controller
        /// </summary>
        event SendMessageDelegate SendMessageEvent;

        /// <summary>
        /// This is fired when the view closes
        /// </summary>
        event CloseEventDelegate CloseEvent;

        /// <summary>
        /// This is fired when a file transfer is being initiated in the view.
        /// </summary>
        event StartFileTransferEventHandler StartFileTransferEvent;

        /// <summary>
        /// This is fired when a file transfer is being canceled in the view.
        /// </summary>
        event CancelFileTransferEventHandler CancelFileTransferEvent;

        #endregion

        #region Properties

        /// <summary>
        /// The contact name for the current conversation view.
        /// </summary>
        string CurrentUserName
        {
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// This fires the SendMessageEvent
        /// </summary>
        /// <param name="message">The text to be sent</param>
        void OnSendMessageEvent(string message);

        /// <summary>
        /// This is called by the conversation controller when a text message is received.
        /// </summary>
        /// <param name="message"></param>
        void AddMessage(string message);

        /// <summary>
        /// Initialises the current view.
        /// </summary>
        /// <param name="caption">The contact name.</param>
        void Initialise(string caption);

        /// <summary>
        /// This fires the CloseEvent.
        /// </summary>
        void OnCloseEvent();

        /// <summary>
        /// This is called by the conversation controller to show the conversation view.
        /// </summary>
        void ShowView();

        /// <summary>
        /// This is called by the conversation controller to close the conversation view.
        /// </summary>
        void CloseView();

        #endregion
    }

    #endregion
}

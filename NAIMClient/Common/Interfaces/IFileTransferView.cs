using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    #region IFileTransferView Interface

    #region Delegates

    /// <summary>
    /// This calls the handler for the Start file transfer event.
    /// </summary>
    /// <param name="username">The user from where the file is requested</param>
    /// <param name="filename">The requested filename</param>
    /// <param name="writeLocation">The location where to save the file</param>
    public delegate void StartFileTransferGenericEventHandler(string username,string filename, string writeLocation);
    
    /// <summary>
    /// This calls the handler for canceling a specific transfer
    /// </summary>
    /// <param name="username"></param>
    /// <param name="filename"></param>
    public delegate void CancelFileTransferGenericEventHandler(string username,string filename);

    /// <summary>
    /// This calls the handler for the Close View Event.
    /// </summary>
    /// <param name="eventArgs"></param>
    public delegate void FileTransferCloseViewEventHandler(object eventArgs);

    /// <summary>
    /// This calls the handler for the GetFileListEvent
    /// </summary>
    /// <param name="username"></param>
    public delegate void GetFileListEventHandler(string username);

    /// <summary>
    /// This calls the handler for the Close View Event.
    /// </summary>
    public delegate void CloseFileTransferViewEventHandler();

    #endregion

    /// <summary>
    /// This should be implemented by a file transfer manager view.
    /// </summary>
    public interface IFileTransferView
    {
        #region Events

        /// <summary>
        /// This is fired when closing the view.
        /// </summary>
        event FileTransferCloseViewEventHandler FileTransferCloseViewEvent;

        /// <summary>
        /// This is fired when a file list is requested.
        /// </summary>
        event GetFileListEventHandler GetFileListEvent;

        /// <summary>
        /// This is fired when a file transfer is started.
        /// </summary>
        event StartFileTransferGenericEventHandler StartFileTransferEvent;

        /// <summary>
        /// This is fired when a file transfer is canceled.
        /// </summary>
        event CancelFileTransferGenericEventHandler CancelFileTransferEvent;

        /// <summary>
        /// This is fired when closing the view.
        /// </summary>
        event CloseFileTransferViewEventHandler CloseFileTransferViewEvent;

        #endregion

        #region Methods

        /// <summary>
        /// This is called by the controller to initialise the view.
        /// </summary>
        void Initialise();

        /// <summary>
        /// this is called by the controller and sets the client list.
        /// </summary>
        /// <param name="contactsByGroups">the list of users grouped by groups</param>
        void SetClientsListSource(IDictionary<string, IList<UserListEntry>> contactsByGroups);

        /// <summary>
        /// this is called by the controller when a contact becomes online.
        /// </summary>
        /// <param name="username">Contact name.</param>
        void ClientOnline(string username);

        /// <summary>
        /// this is called by the controller when a contact becomes offline.
        /// </summary>
        /// <param name="username">Contact name.</param>
        void ClientOffline(string username);

        /// <summary>
        /// This fires the Close View Event.
        /// </summary>
        /// <param name="eventArgs"></param>
        void OnFileTransferCloseViewEvent(object eventArgs);

        /// <summary>
        /// This is called by the controller when a file transfer has been initiated in a conversation controller.
        /// </summary>
        void StartFileTransfer(string userName, string fileName);

        /// <summary>
        /// This is called by the controller when a file transfer has been canceled in a conversation controller.
        /// </summary>
        void CancelFileTransfer(string userName, string fileName);

        /// <summary>
        /// This fires the GetFileListEvent.
        /// </summary>
        /// <param name="username"></param>
        void OnGetFileListEvent(string username);

        /// <summary>
        /// This is called by the controller to show a file list from a specific contact.
        /// </summary>
        void ShowFileList(IList<string> fileList);

        /// <summary>
        /// This fires the StartGenericFileTransferEvent.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="filename"></param>
        /// <param name="writelocation"></param>
        void OnStartFileTransferEvent(string username, string filename,string writelocation);

        /// <summary>
        /// This fires the CancelGenericFileTransfer.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="filename"></param>
        void OnCancelFileTransferEvent(string username, string filename);

        /// <summary>
        /// This is called by the controller when a file transfer changes progress.
        /// </summary>
        void ChangeFileTransferProgress(int percentage);

        /// <summary>
        /// This fires the close view event.
        /// </summary>
        void OnCloseFileTransferViewEvent();

        /// <summary>
        /// This is called from the controller to show the view.
        /// </summary>
        void ShowView();

        #endregion
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    public delegate void StartFileTransferGenericEventHandler(string username,string filename, string writeLocation);
    public delegate void CancelFileTransferGenericEventHandler(string username,string filename);
    public interface IFileTransferView
    {
        event FileTransferCloseViewEventHandler FileTransferCloseViewEvent;

        event GetFileListEventHandler GetFileListEvent;

        event StartFileTransferGenericEventHandler StartFileTransferEvent;

        event CancelFileTransferGenericEventHandler CancelFileTransferEvent;

        event CloseFileTransferViewEventHandler CloseFileTransferViewEvent;
        /// <summary>
        /// This is called by the controller
        /// </summary>
        void Initialise();

        /// <summary>
        /// this is called by the controller
        /// </summary>
        /// <param name="contactsByGroups"></param>
        void SetClientsListSource(IDictionary<string, IList<UserListEntry>> contactsByGroups);

        /// <summary>
        /// this is called by the controller
        /// </summary>
        /// <param name="username"></param>
        void ClientOnline(string username);

        /// <summary>
        /// this is called by the controller
        /// </summary>
        /// <param name="username"></param>
        void ClientOffline(string username);

        void OnFileTransferCloseViewEvent(object eventArgs);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void StartFileTransfer(string userName, string fileName);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void CancelFileTransfer(string userName, string fileName);

        void OnGetFileListEvent(string username);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ShowFileList(IList<string> fileList);

        void OnStartFileTransferEvent(string username, string filename,string writelocation);

        void OnCancelFileTransferEvent(string username, string filename);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ChangeFileTransferProgress(int percentage);

        void OnCloseFileTransferViewEvent();

        void ShowView();
    }

    public delegate void FileTransferCloseViewEventHandler(object eventArgs);

    public delegate void GetFileListEventHandler(string username);

    public delegate void CloseFileTransferViewEventHandler();
}

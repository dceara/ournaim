using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IFileTransferView
    {
        event FileTransferCloseViewEventHandler FileTransferCloseViewEvent;

        event GetFileListEventHandler GetFileListEvent;

        event StartFileTransferEventHandler StartFileTransferEvent;

        event CancelFileTransferEventHandler CancelFileTransferEvent;

        event CloseFileTransferViewEventHandler CloseFileTransferViewEvent;
        /// <summary>
        /// This is called by the controller
        /// </summary>
        void Initialise();

        void OnFileTransferCloseViewEvent(object eventArgs);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void StartFileTransfer(string userName, string fileName);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void CancelFileTransfer(string userName, string fileName);

        void OnGetFileListEvent(object eventArgs);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ShowFileList(IList<string> fileList);

        void OnStartFileTransferEvent(object eventArgs);

        void OnCancelFileTransferEvent(object eventArgs);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ChangeFileTransferProgress(int percentage);

        void OnCloseFileTransferViewEvent(object eventArgs);
    }

    public delegate void FileTransferCloseViewEventHandler(object eventArgs);

    public delegate void GetFileListEventHandler(object eventArgs);

    public delegate void CloseFileTransferViewEventHandler(object eventArgs);
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;
namespace GUI
{
    public class FileTransferView : Form,IFileTransferView
    {
        #region IFileTransferView Members

        public event FileTransferCloseViewEventHandler FileTransferCloseViewEvent;

        public event GetFileListEventHandler GetFileListEvent;

        public event StartFileTransferEventHandler StartFileTransferEvent;

        public event CancelFileTransferEventHandler CancelFileTransferEvent;

        public event CloseFileTransferViewEventHandler CloseFileTransferViewEvent;

        public void Initialise()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnFileTransferCloseViewEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void StartFileTransfer(string userName, string fileName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void CancelFileTransfer(string userName, string fileName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnGetFileListEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ShowFileList(IList<string> fileList)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnStartFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCancelFileTransferEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ChangeFileTransferProgress(int percentage)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void OnCloseFileTransferViewEvent(object eventArgs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ShowView()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}

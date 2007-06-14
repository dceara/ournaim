using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    #region IFileTransferView Interface

    #region Delegates

    public delegate void ViewClosedEventHandler();
    public delegate void ContactSelectedEventHandler(string contact);
    public delegate void GetContactListEventHandler(string contact);
    public delegate void StartFileTransferEventHandler(string contact, string file);
    public delegate void CancelFileTransferEventHandler(string contact, string file);


    #endregion

    /// <summary>
    /// This should be implemented by a file transfer manager view.
    /// </summary>
    public interface IFileTransferView
    {
        #region Events

        event ViewClosedEventHandler ViewClosedEvent;
        event ContactSelectedEventHandler ContactSelectedEvent;
        event GetContactListEventHandler GetContactListEvent;
        event StartFileTransferEventHandler StartFileTransferEvent;
        event CancelFileTransferEventHandler CancelFileTransferEvent;

        #endregion

        #region Methods

        void Initialise(ICollection<string> contacts);

        void AddContact(string contact);

        void RemoveContact(string contact);

        void ContactOnline(string contact);

        void ContactOffline(string contact);

        void LoadList(string contact, IList<string> list);

        void StartFileTransfer(string contact, string file);

        void CancelFileTransfer(string contact, string file);

        void UpdateTransferProgress(string contact, string file, int progress);

        void FileTransferFinished(string contact, string file);

        void ShowView();

        void HideView();

        void CloseView();

        #endregion
    }
    #endregion
}

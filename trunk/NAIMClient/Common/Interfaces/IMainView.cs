using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IMainView
    {
        event LoginEventHandler LoginEvent;

        event LogoutEventHandler LogoutEvent;

        event ChangeStatusEventHandler ChangeStatusEvent;

        event AddContactEventHandler AddContactEvent;

        event RemoveContactEventHandler RemoveContactEvent;

        event ChangeContactGroupEventHandler ChangeContactGroupEvent;

        event OpenConversationEventHandler OpenConversationEvent;

        event OpenFileTransferViewEventHandler OpenFileTransferViewEvent;

        event MainCloseEventHandler MainCloseEvent;

        void OnLoginEvent(object eventArgs);

        void OnLogoutEvent(object eventArgs);

        void OnChangeStatusEvent(object eventArgs);

        void OnAddContactEvent(object eventArgs);

        void OnRemoveContactEvent(object eventArgs);

        void OnChangeContactGroupEvent(object eventArgs);

        void OnOpenConversationEvent(string userName);

        void OnOpenFileTransferViewEvent(object eventArgs);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ChangeClientStatus(string userName, string newStatus);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ClientOnline(string userName);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void ClientOffline(string userName);

        /// <summary>
        /// This is called by the controller
        /// </summary>
        void Initialise();

        void OnMainClose(object eventArgs);
    }

    public delegate void LoginEventHandler(object eventArgs);

    public delegate void LogoutEventHandler(object eventArgs);

    public delegate void ChangeStatusEventHandler(object eventArgs);

    public delegate void AddContactEventHandler(object eventArgs);

    public delegate void RemoveContactEventHandler(object eventArgs);

    public delegate void ChangeContactGroupEventHandler(object eventArgs);

    public delegate void OpenConversationEventHandler(string userName);

    public delegate void OpenFileTransferViewEventHandler(object eventArgs);

    public delegate void MainCloseEventHandler(object eventArgs);
}

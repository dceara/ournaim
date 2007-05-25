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

        event OpenSignUpViewHandler OpenSignUpViewEvent;

        void OnLoginEvent(string userName,string password);

        void OnLogoutEvent(object eventArgs);

        void OnChangeStatusEvent(string eventArgs);

        void OnAddContactEvent(object eventArgs);

        void OnRemoveContactEvent(object eventArgs);

        void OnChangeContactGroupEvent(object eventArgs);

        void OnOpenConversationEvent(string userName);

        void OnOpenFileTransferViewEvent();

        void OnOpenSignUpViewEvent();

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

        void AfterSignIn();

        void OnMainClose(object eventArgs);

        void ShowView();

        void ChangeStatus(string status);
    }

    public delegate void LoginEventHandler(string userName,string password);

    public delegate void LogoutEventHandler(object eventArgs);

    public delegate void ChangeStatusEventHandler(string eventArgs);

    public delegate void AddContactEventHandler(object eventArgs);

    public delegate void RemoveContactEventHandler(object eventArgs);

    public delegate void ChangeContactGroupEventHandler(object eventArgs);

    public delegate void OpenConversationEventHandler(string userName);

    public delegate void OpenFileTransferViewEventHandler();

    public delegate void MainCloseEventHandler(object eventArgs);

    public delegate void OpenSignUpViewHandler();
}

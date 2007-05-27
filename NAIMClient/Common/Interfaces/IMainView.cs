using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    public interface IMainView
    {
        event LoginEventHandler LoginEvent;

        event LogoutEventHandler LogoutEvent;

        event ChangeStatusEventHandler ChangeStatusEvent;

        event AddContactEventHandler AddContactEvent;

        event AddGroupEventHandler AddGroupEvent;

        event RemoveContactEventHandler RemoveContactEvent;

        event ChangeContactGroupEventHandler ChangeContactGroupEvent;

        event OpenConversationEventHandler OpenConversationEvent;

        event OpenFileTransferViewEventHandler OpenFileTransferViewEvent;

        event MainCloseEventHandler MainCloseEvent;

        event OpenSignUpViewHandler OpenSignUpViewEvent;

        void OnLoginEvent(string userName,string password);

        void OnLogoutEvent();

        void OnChangeStatusEvent(string eventArgs);

        void OnAddContactEvent(string uname, string group);

        void OnAddGroupEvent(string group);

        void OnRemoveContactEvent(string username);

        void OnChangeContactGroupEvent(string contact, string newGroup);

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

        void OnMainClose();


        /// <summary>
        /// sets the source for the groups dropdown and the group names in the contact list
        /// </summary>
        /// <param name="list"></param>
        void SetGroupSource(IList<string> groupNames, IDictionary<string,IList<UserListEntry> > contactsByGroups);

        void ShowView();

        void ChangeStatus(string status);
    }

    public delegate void LoginEventHandler(string userName,string password);

    public delegate void LogoutEventHandler();

    public delegate void ChangeStatusEventHandler(string newStatus);

    public delegate void AddContactEventHandler(string uname,string group);

    public delegate void AddGroupEventHandler(string group);

    public delegate void RemoveContactEventHandler(string userName);

    public delegate void ChangeContactGroupEventHandler(string username,string newGroup);

    public delegate void OpenConversationEventHandler(string userName);

    public delegate void OpenFileTransferViewEventHandler();

    public delegate void MainCloseEventHandler();

    public delegate void OpenSignUpViewHandler();
}

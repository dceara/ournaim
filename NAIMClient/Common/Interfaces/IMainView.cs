using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.Interfaces
{
    #region IMainView Interface

    #region Delegates

    public delegate void LoginEventHandler(string userName, string password);

    public delegate void LogoutEventHandler();

    public delegate void ChangeStatusEventHandler(string newStatus);

    public delegate void AddContactEventHandler(string uname, string group);

    public delegate void AddGroupEventHandler(string group);

    public delegate void RemoveContactEventHandler(string userName);

    public delegate void ChangeContactGroupEventHandler(string username, string newGroup);

    public delegate void OpenConversationEventHandler(string userName);

    public delegate void OpenFileTransferViewEventHandler();

    public delegate void MainCloseEventHandler();

    public delegate void OpenSignUpViewHandler();

    public delegate void OpenArchiveViewHandler();

    #endregion

    /// <summary>
    /// This should be implemented by the main view.
    /// </summary>
    public interface IMainView
    {
        #region Events

        /// <summary>
        /// Is fired at login
        /// </summary>
        event LoginEventHandler LoginEvent;

        /// <summary>
        /// Is fired at logout.
        /// </summary>
        event LogoutEventHandler LogoutEvent;

        /// <summary>
        /// Is fired when the status is changed in the view.
        /// </summary>
        event ChangeStatusEventHandler ChangeStatusEvent;

        /// <summary>
        /// Is fired when a contact is being added.
        /// </summary>
        event AddContactEventHandler AddContactEvent;

        /// <summary>
        /// Is fired when a group is being added.
        /// </summary>
        event AddGroupEventHandler AddGroupEvent;

        /// <summary>
        /// Is fired when a contact is being removed.
        /// </summary>
        event RemoveContactEventHandler RemoveContactEvent;

        /// <summary>
        /// Is fired when a contact is moved into another group.
        /// </summary>
        event ChangeContactGroupEventHandler ChangeContactGroupEvent;

        /// <summary>
        /// Is fired when a conversation view is being opened.
        /// </summary>
        event OpenConversationEventHandler OpenConversationEvent;

        /// <summary>
        /// Is fired when the file transfer view is being opened.
        /// </summary>
        event OpenFileTransferViewEventHandler OpenFileTransferViewEvent;

        /// <summary>
        /// Is fired when the main view is being closed.
        /// </summary>
        event MainCloseEventHandler MainCloseEvent;

        /// <summary>
        /// Is fired when the sign up view is being opened.
        /// </summary>
        event OpenSignUpViewHandler OpenSignUpViewEvent;

        event OpenArchiveViewHandler OpenArchiveViewEvent;

        #endregion

        #region Methods

        /// <summary>
        /// Fires the login event.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        void OnLoginEvent(string userName,string password);

        /// <summary>
        /// Fires the logout event.
        /// </summary>
        void OnLogoutEvent();

        /// <summary>
        /// Fires the change status event.
        /// </summary>
        /// <param name="eventArgs"></param>
        void OnChangeStatusEvent(string eventArgs);

        /// <summary>
        /// Fires the AddContactEvent.
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="group"></param>
        void OnAddContactEvent(string uname, string group);

        /// <summary>
        /// Fires the AddGroupEvent.
        /// </summary>
        /// <param name="group"></param>
        void OnAddGroupEvent(string group);

        /// <summary>
        /// Fires the remove contact event.
        /// </summary>
        /// <param name="username"></param>
        void OnRemoveContactEvent(string username);

        /// <summary>
        /// Fires the ChangeContactGroupEvent.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="newGroup"></param>
        void OnChangeContactGroupEvent(string contact, string newGroup);

        /// <summary>
        /// Fires the OpenConversationEvent.
        /// </summary>
        /// <param name="userName"></param>
        void OnOpenConversationEvent(string userName);

        /// <summary>
        /// Fires the OpenFileTransferViewEvent.
        /// </summary>
        void OnOpenFileTransferViewEvent();

        /// <summary>
        /// Fires the OpenSignUpViewEvent.
        /// </summary>
        void OnOpenSignUpViewEvent();

        /// <summary>
        /// This is called by the controller when a contact changes his status.
        /// </summary>
        void ChangeClientStatus(string userName, string newStatus);

        /// <summary>
        /// This is called by the controller when a contact becomes online
        /// </summary>
        void ClientOnline(string userName, string status);

        /// <summary>
        /// This is called by the controller when a contact becomes offline
        /// </summary>
        void ClientOffline(string userName);

        /// <summary>
        /// This is called by the controller to initialise the view.
        /// </summary>
        void Initialise();

        /// <summary>
        /// This is called by the controller to initialise the view after sign in.
        /// </summary>
        void AfterSignIn(string userName);

        /// <summary>
        /// This fires the Close view event.
        /// </summary>
        void OnMainClose();


        /// <summary>
        /// sets the source for the groups dropdown and the group names in the contact list
        /// </summary>
        /// <param name="list"></param>
        void SetGroupSource(IList<string> groupNames, IDictionary<string,IList<UserListEntry> > contactsByGroups);

        /// <summary>
        /// This is called by the controller to show the view.
        /// </summary>
        void ShowView();

        void AddGroup(string groupName);

        void RemoveContact(string contactName);

        void OnOpenArchiveView();

        #endregion
    }

    #endregion
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    #region ICreateAccountView Interface

    #region Delegates

    /// <summary>
    /// Calls the handler for the CreateAccountEvent.
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    public delegate void CreateAccountEventHandler(string userName, string password);

    /// <summary>
    /// Calls the handler for the CloseAccountViewEvent
    /// </summary>
    public delegate void CloseAccountViewEventHandler();

    #endregion

    /// <summary>
    /// This should be implemented by the view that creates a new account
    /// </summary>
    public interface ICreateAccountView
    {
        #region Events

        /// <summary>
        /// This is fired when a new account is created
        /// </summary>
        event CreateAccountEventHandler CreateAccountEvent;

        /// <summary>
        /// This is fired when the view is closed.
        /// </summary>
        event CloseAccountViewEventHandler CloseAccountViewEvent;

        #endregion

        #region Methods

        /// <summary>
        /// This fires the CreateAccountEvent.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        void OnCreateAccountEvent(string userName,string password);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void Initialise();

        /// <summary>
        /// This fires the CloseAccountViewEvent.
        /// </summary>
        void OnCloseAccountViewEvent();

        /// <summary>
        /// This is called by the main controller to show the create account view.
        /// </summary>
        void ShowView();

        /// <summary>
        /// This is called by the main controller to close the create account view.
        /// </summary>
        void CloseView();

        #endregion
    }

    #endregion
}

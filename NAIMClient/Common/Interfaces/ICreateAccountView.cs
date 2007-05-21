using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface ICreateAccountView
    {
        event CreateAccountEventHandler CreateAccountEvent;

        event CloseAccountViewEventHandler CloseAccountViewEvent;

        void OnCreateAccountEvent(string userName,string password);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void Initialise();

        void OnCloseAccountViewEvent();

        void ShowView();

        void CloseView();
    }

    public delegate void CreateAccountEventHandler(string userName,string password);

    public delegate void CloseAccountViewEventHandler();
}

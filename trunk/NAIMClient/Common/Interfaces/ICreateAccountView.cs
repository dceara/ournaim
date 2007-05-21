using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface ICreateAccountView
    {
        event CreateAccountEventHandler CreateAccountEvent;

        event CloseAccountViewEventHandler CloseAccountViewEvent;

        void OnCreateAccountEvent(object eventArgs);

        /// <summary>
        /// This is called by the main controller
        /// </summary>
        void Initialise();

        void OnCloseAccountViewEvent(object eventArgs);
    }

    public delegate void CreateAccountEventHandler(object eventArgs);

    public delegate void CloseAccountViewEventHandler(object eventArgs);
}

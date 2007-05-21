using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI;
using Controllers;

namespace MainProject
{
    
    static class Program
    {
        static MainController mainController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            MainView mainView = new MainView();

            mainController = new MainController();

            mainController.InstantiateConversationViewEvent += new InstantiateConversationView(mainController_InstantiateConversationViewEvent);

            mainController.InstantiateCreateAccountViewEvent += new InstantiateCreateAccountView(mainController_InstantiateCreateAccountViewEvent);

            mainController.InstantiateFileTransferViewEvent += new InstantiateFileTransferView(mainController_InstantiateFileTransferViewEvent);

            mainController.Initialise(mainView);

            Application.Run(mainView);
        }

        

        #region Main Controller Event Handlers

        static void mainController_InstantiateCreateAccountViewEvent()
        {
            mainController.InitialiseCreateAccount(new CreateAccountView());
        }

        static void mainController_InstantiateConversationViewEvent(string username)
        {
            mainController.InitialiseConversation(username, new ConversationView());
        }

        static void mainController_InstantiateFileTransferViewEvent()
        {
            mainController.InitialiseFileTransferManager(new FileTransferView());
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI;
using Controllers;
using GUI.Views;

namespace MainProject
{
    
    static class Program
    {
        #region Main Controller

        static MainController mainController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);


            //Test test = new Test();

            //test.ShowDialog();

            MainView mainView = new MainView();

            mainController = new MainController();

            //mainController.LocalPort = (ushort)test.numericUpDown1.Value;

            mainController.InstantiateConversationViewEvent += new InstantiateConversationView(mainController_InstantiateConversationViewEvent);

            mainController.InstantiateCreateAccountViewEvent += new InstantiateCreateAccountView(mainController_InstantiateCreateAccountViewEvent);

            mainController.InstantiateFileTransferViewEvent += new InstantiateFileTransferView(mainController_InstantiateFileTransferViewEvent);

            mainController.InstantiateArchiveViewEvent += new InstantiateArchiveView(mainController_InstantiateArchiveViewEvent);

            mainController.Initialise(mainView);

            Application.Run(mainView);
        }

        #endregion

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

        static Common.Interfaces.IArchiveView mainController_InstantiateArchiveViewEvent()
        {
            return new ArchiveView();
        }

        #endregion
    }
}
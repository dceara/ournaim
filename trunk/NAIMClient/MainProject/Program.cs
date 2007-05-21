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

            mainController.Initialise(mainView);

            Application.Run(mainView);
        }

        static void mainController_InstantiateConversationViewEvent(string username)
        {
            mainController.InitialiseConversation(username, new ConversationView());
        }

    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI;
using Controllers;

namespace MainProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView mainView = new MainView();
            MainController mainController = new MainController();

            mainController.Initialise();

            Application.Run(mainView);
        }
    }
}
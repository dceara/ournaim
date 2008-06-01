using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SchemeGuiEditor.Services
{
    public static class MessageService
    {
        static Form mainForm;

        public static Form MainForm
        {
            get
            {
                return mainForm;
            }
            set
            {
                mainForm = value;
            }
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(MessageService.MainForm,message,"Error",MessageBoxButtons.OK);
        }
    }
}

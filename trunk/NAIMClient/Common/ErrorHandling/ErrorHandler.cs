using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Common.ErrorHandling
{
    public class ErrorHandler
    {
        public static void HandleError(string errorMessage, string caption, IWin32Window parent)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ShowCallback), new object[] { errorMessage,caption,parent });
        }
        private static void ShowCallback(object stateInfo)
        {
            object[] args = stateInfo as object[];
            if (args.Length < 3)
                return;
            string errorMessage = args[0] as string;
            if (errorMessage == null)
                return;
            string caption = args[1] as string;
            if (caption == null)
                return;
            IWin32Window parent = args[2] as IWin32Window;
            if (parent == null)
                return;
            ShowErrorForm(errorMessage, caption, parent);
        }
        private static void ShowErrorForm(string errorMessage, string caption, IWin32Window parent)
        {
            ErrorForm errorForm = new ErrorForm();
            errorForm.ShowDialog(parent, errorMessage, caption);
        }
    }
}

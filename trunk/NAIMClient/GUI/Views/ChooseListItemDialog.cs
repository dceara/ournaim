using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public class ChooseListItemDialog
    {

        public delegate void DialogClosedDelegate(string filePath, string alias);

        public static void Show(object stateInfo)
        {
            object[] args = stateInfo as object[];
            if (args == null)
                return;
            if (args.Length < 2)
                return;
            IWin32Window parent = args[0] as IWin32Window;
            if (parent == null)
                return;

            DialogClosedDelegate callback = args[1] as DialogClosedDelegate;
            if (callback == null)
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog((IWin32Window)parent) != DialogResult.OK)
            {
                return;
            }
            FileListAliasChooser aliasChooser = new FileListAliasChooser();
            aliasChooser.ShowDialog((IWin32Window)parent);
            string alias = aliasChooser.Alias;
            callback(openFileDialog.FileName, alias);
        }

    }
}

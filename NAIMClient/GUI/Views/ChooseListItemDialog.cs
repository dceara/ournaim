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
            openFileDialog.AddExtension = true;
            if (openFileDialog.ShowDialog((IWin32Window)parent) != DialogResult.OK)
            {
                return;
            }
            string fileName = openFileDialog.FileName;
            int index = fileName.LastIndexOf('.');
            string extension = "";
            if (index != -1)
            {
                extension = fileName.Substring(index);
            }
            FileListAliasChooser aliasChooser = new FileListAliasChooser();
            aliasChooser.FileName = fileName;
            aliasChooser.ShowDialog((IWin32Window)parent);
            string alias = aliasChooser.Alias;
            if (alias.LastIndexOf('.') == -1)
            {
                alias += extension;
            }
            callback(openFileDialog.FileName, alias);
        }

    }
}

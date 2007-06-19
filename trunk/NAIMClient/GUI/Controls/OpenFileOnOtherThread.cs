using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GUI.Views;

namespace GUI.Controls
{

    public interface IOpenFileOnOtherThread
    {        
        void dialogClosed(string filePath, string alias);
    }

    class OpenFileOnOtherThread
    {
        private IOpenFileOnOtherThread _parent;

        public OpenFileOnOtherThread(IOpenFileOnOtherThread parent) 
        {
            this._parent = parent;
        }

        public void Show(Object stateInfo) 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog((IWin32Window)_parent) != DialogResult.OK) 
            {
                return;
            }
            FileListAliasChooser aliasChooser = new FileListAliasChooser();
            aliasChooser.ShowDialog((IWin32Window)_parent);
            string alias = aliasChooser.Alias;
            _parent.dialogClosed(openFileDialog.FileName,alias);
        }
        public IOpenFileOnOtherThread Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
    }
}

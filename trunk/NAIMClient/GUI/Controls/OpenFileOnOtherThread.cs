using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GUI.Views;

namespace GUI.Controls
{

    public interface IOpenFileOnOtherThread
    {        
        void dialogClosed(IOpenDialogEventArgs args);
    }

    
    abstract class AOpenDialogOnOtherThread
    {
        protected IOpenFileOnOtherThread _parent;

        public AOpenDialogOnOtherThread(IOpenFileOnOtherThread parent) 
        {
            this._parent = parent;
        }

        abstract public void Show(Object stateInfo);

        public IOpenFileOnOtherThread Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
    }

    class OpenFileOnOtherThread:AOpenDialogOnOtherThread
    {
        public OpenFileOnOtherThread(IOpenFileOnOtherThread parent)
            : base(parent)
        {
        }

        public override void  Show(object stateInfo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog((IWin32Window)_parent) != DialogResult.OK)
            {
                return;
            }
            FileListAliasChooser aliasChooser = new FileListAliasChooser();
            aliasChooser.ShowDialog((IWin32Window)_parent);
            string alias = aliasChooser.Alias;
            _parent.dialogClosed(new OpenFileEventArgs(openFileDialog.FileName, alias));
        }
    }

    public interface IOpenDialogEventArgs
    {

    }

    public class OpenFileEventArgs:IOpenDialogEventArgs
    {
        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _alias;

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }
	

        public OpenFileEventArgs(string filePath, string alias)
        {
            this._filePath = filePath;
            this._alias = alias;
        }

    }

}

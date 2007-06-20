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

    class OpenAddContactDialogOnOtherThread : AOpenDialogOnOtherThread
    {
        public OpenAddContactDialogOnOtherThread(IOpenFileOnOtherThread parent)
            : base(parent)
        {
        }

        public override void Show(object stateInfo)
        {
            object[] args = (object[])stateInfo;
            string[] groups = (string[])args[0];
            AddContactDialog addContactDialog;
            if (args.Length > 1)
            {
                string group = (string)args[1];
                addContactDialog = new AddContactDialog(groups, group);
            }
            else
            {
                addContactDialog = new AddContactDialog(groups);
            }
            
            DialogResult result = addContactDialog.ShowDialog((IWin32Window)_parent);
            if (result != DialogResult.OK)
            {
                return;
            }
            _parent.dialogClosed(new AddContactDialogEventArgs(addContactDialog.Username,addContactDialog.Group));

        }
    }

    class OpenAddGroupOnOtherThread : AOpenDialogOnOtherThread
    {
        public OpenAddGroupOnOtherThread(IOpenFileOnOtherThread parent)
            : base(parent)
        {
        }
        public override void Show(object stateInfo)
        {
            AddGroupView addGroupView = new AddGroupView();
            DialogResult result = addGroupView.ShowDialog((IWin32Window)_parent);
            if (result != DialogResult.OK)
            {
                return;
            }
            _parent.dialogClosed(new AddGroupDialogEventArgs(addGroupView.Group));
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

    public class AddContactDialogEventArgs : IOpenDialogEventArgs
    {
        private string _contact;

        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public AddContactDialogEventArgs(string contact, string group)
        {
            this._contact = contact;
            this._group = group;
        }
    }

    public class AddGroupDialogEventArgs : IOpenDialogEventArgs
    {

        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public AddGroupDialogEventArgs(string group)
        {
            this._group = group;
        }
    }
}

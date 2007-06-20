using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AddContactDialog : Form
    {
        public delegate void DialogClosedDelegate(string contact, string group);

        #region Properties

        public string Username
        {
            get { return this.usernickname.Text; }
        }

        public string Group
        {
            get { return group_comboBox.Text; }
        }

        #endregion

        #region Constructors

        public AddContactDialog(string[] groups)
        {
            InitializeComponent();

            foreach(string group in groups)
            {
                group_comboBox.Items.Add(group);
            }

            group_comboBox.SelectedIndex = 0;
        }

        public AddContactDialog(string[] groups, string selectedGroup)
        {
            InitializeComponent();

            foreach (string group in groups)
            {
                group_comboBox.Items.Add(group);
            }

            int index = group_comboBox.Items.IndexOf(selectedGroup);
            if (index != -1) 
            {
                group_comboBox.SelectedIndex = index;
            }
            else
            {
                group_comboBox.SelectedIndex = 0;
            }
        }

        #endregion

        #region GUI

        private void AddContactDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK && this.usernickname.Text == String.Empty)
            {
                MessageBox.Show("The Contact Name cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        #endregion

        #region Threading

        public static void Show(object stateInfo)
        {
            object[] args = stateInfo as object[];
            if (args == null)
                return;
            if (args.Length < 4)
                return;
            IWin32Window parent = args[0] as IWin32Window;
            if (parent == null)
                return;
            DialogClosedDelegate callback = args[1] as DialogClosedDelegate;
            if (callback == null)
                return;
            string[] groups = args[2] as string[];
            if (groups == null)
                return;
            string group = args[3] as string;
            AddContactDialog addContactDialog;
            if (group == null)
            {
                addContactDialog = new AddContactDialog(groups);
            }
            else
            {
                addContactDialog = new AddContactDialog(groups, group);
            }
            DialogResult result = addContactDialog.ShowDialog((IWin32Window)parent);
            if (result != DialogResult.OK)
            {
                return;
            }
            callback(addContactDialog.Username, addContactDialog.Group);
        }

        #endregion

    }
}
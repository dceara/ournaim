using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Interfaces;

namespace GUI.Views
{
    public partial class ArchiveView : Form,IArchiveView
    {
        #region Constructors
        public ArchiveView()
        {
            InitializeComponent();
        } 
        #endregion

        #region IArchiveView Members

        private IList<KeyValuePair<string, IList<string>>> _archive = null;

        public void ShowDialog(IList<KeyValuePair<string, IList<string>>> archive)
        {
            _archive = archive;
            foreach(KeyValuePair<string,IList<string> > entry in archive)
            {
                this.listViewContacts.Items.Add(new ListViewItem(entry.Key));
                
            }
            this.listViewContacts.Update();
            this.ShowDialog();
        }

        #endregion

        private void listViewContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewMessages.Items.Clear();
            if (this.listViewContacts.SelectedIndices.Count > 0)
            {
                string user = listViewContacts.SelectedItems[0].Text;
                foreach (KeyValuePair<string, IList<string>> entry in _archive)
                {
                    bool found = false;
                    if (entry.Key == user)
                    {
                        foreach(string message in entry.Value)
                        {
                            string[] values = message.Split(new char[]{' '});
                            if (values.Length < 4)
                                continue;
                            this.listViewMessages.Items.Add(new ListViewItem(new string[] { values[0] + " " + values[1] + values[2],values[3] }));
                            
                        }
                        found = true;
                        break;
                    }
                    if(found)
                        break;
                }
                listViewMessages.Update();
            }

        }
    }
}
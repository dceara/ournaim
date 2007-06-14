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

        public void ShowDialog(IList<KeyValuePair<string, IList<string>>> archive, string contactName)
        {
            _archive = archive;
            int index = -1;
            int i = 0;
            foreach(KeyValuePair<string,IList<string> > entry in archive)
            {
                this.listViewContacts.Items.Add(new ListViewItem(entry.Key));
                if(entry.Key == contactName)
                    index = i;
                i++;
            }
            if (index != -1)
            {

                listViewContacts.SelectedIndices.Add(index);
            }
            this.listViewContacts.Update();
            this.Show();
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
                            string date = "";
                            for (int i = 0; i < values.Length - 1; ++i)
                            {
                                date += values[i] + " ";
                            }
                            this.listViewMessages.Items.Add(new ListViewItem(new string[] { date, values[values.Length - 1] }));
                            
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
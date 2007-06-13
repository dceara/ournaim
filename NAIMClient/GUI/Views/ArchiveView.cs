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

        public void ShowDialog(IList<KeyValuePair<string, IList<string>>> archive)
        {
            this.ShowDialog();
        }

        #endregion
    }
}
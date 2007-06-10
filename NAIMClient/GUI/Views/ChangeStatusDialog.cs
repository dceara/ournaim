using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class ChangeStatusDialog : Form
    {
        #region Properties

        public string Status
        {
            get { return txtStatus.Text; }
        }
        
        #endregion

        #region Constructors

        public ChangeStatusDialog()
        {
            InitializeComponent();
        }
        
        #endregion
    }
}
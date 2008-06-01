using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SchemeGuiEditor.Gui;

namespace SchemeGuiEditor.Gui
{
    public partial class PropertyWindow : ToolWindow
    {
        public PropertyWindow()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }

        public void LoadPropertyItems(List<object> items)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(items.ToArray());
        }

        public void SelectItem(object item)
        {
            if (comboBox.Items.Contains(item))
            {
                comboBox.SelectedItem = item;
            }
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = comboBox.SelectedItem;
        }
    }
}
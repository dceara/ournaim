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
        private List<object> _propertyObjects;

        public PropertyWindow()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }

        public void LoadPropertyItems(List<object> items)
        {
            _propertyObjects = items;
            FillCombo();
        }

        public void SelectItem(object item)
        {
            if (comboBox.Items.Contains(item))
            {
                comboBox.SelectedItem = item;
            }
            else
            {
                FillCombo();
                comboBox.SelectedItem = item;
            }
        }

        private int ComparePropertyObjects(object obj1, object obj2)
        {
            return obj1.ToString().CompareTo(obj2.ToString());
        }

        private void FillCombo()
        {
            _propertyObjects.Sort(new Comparison<object>(ComparePropertyObjects));
            comboBox.Items.Clear();
            comboBox.Items.AddRange(_propertyObjects.ToArray());
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = comboBox.SelectedItem;
        }
    }
}
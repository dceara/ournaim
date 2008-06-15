using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SchemeGuiEditor.Gui;
using SchemeGuiEditor.ToolboxControls;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.Gui
{
    public partial class PropertyWindow : ToolWindow
    {
        public event EventHandler<DataEventArgs<IScmControl>> SelectedControlChanged;

        private List<IScmControlProperties> _propertyObjects;
        private bool _throwEvent;
        
        public PropertyWindow()
        {
            InitializeComponent();
            _throwEvent = true;
            comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }

        public void LoadPropertyItems(List<IScmControlProperties> items)
        {
            _propertyObjects = items;
            FillCombo();
        }

        public void SelectItem(object item)
        {
            _throwEvent = false;
            if (item != null && comboBox.Items.Contains(item))
            {
                comboBox.SelectedItem = item;
            }
            else
            {
                FillCombo();
                comboBox.SelectedItem = item;
            }
            if (item == null)
                comboBox_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private int ComparePropertyObjects(IScmControlProperties obj1, IScmControlProperties obj2)
        {
            return obj1.ToString().CompareTo(obj2.ToString());
        }

        private void FillCombo()
        {
            _propertyObjects.Sort(new Comparison<IScmControlProperties>(ComparePropertyObjects));
            comboBox.Items.Clear();
            comboBox.Items.AddRange(_propertyObjects.ToArray());
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IScmControlProperties ctrl;
            if (propertyGrid.SelectedObject != null && propertyGrid.SelectedObject is IScmControlProperties)
            {
                ctrl = propertyGrid.SelectedObject as IScmControlProperties;
                ctrl.PropertyChanged -= new EventHandler(ctrl_PropertyChanged);
            }
            propertyGrid.SelectedObject = comboBox.SelectedItem;

            if (propertyGrid.SelectedObject is IScmControlProperties)
            {
                ctrl = propertyGrid.SelectedObject as IScmControlProperties;
                ctrl.PropertyChanged += new EventHandler(ctrl_PropertyChanged);
            }

            if (_throwEvent && SelectedControlChanged != null)
                SelectedControlChanged(this, new DataEventArgs<IScmControl>((comboBox.SelectedItem as IScmControlProperties).Control));
            else
                _throwEvent = true;
        }

        void ctrl_PropertyChanged(object sender, EventArgs e)
        {
            propertyGrid.Refresh();
        }
    }
}
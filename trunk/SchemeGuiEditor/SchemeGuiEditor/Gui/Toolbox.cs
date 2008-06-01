using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Silver.UI;
using SchemeGuiEditor.ToolboxControls;

namespace SchemeGuiEditor.Gui
{
    public partial class Toolbox : ToolWindow
    {
        public Toolbox()
        {
            InitializeComponent();
            InitialiseToolboxItems();
        }

        private void InitialiseToolboxItems()
        {
            List<ToolBoxItem> items = new List<ToolBoxItem>();
            ToolBoxTab tab = new ToolBoxTab();
            tab.Caption = "All Controls";
            toolBox1.AddTab(tab);
            items.AddRange(GetCommonControls());
            items.AddRange(GetContainerControls());
            items.Sort(new Comparison<ToolBoxItem>(CompareToolboxItem));
            tab.AddItem("Pointer");
            foreach (ToolBoxItem item in items)
                tab.AddItem(item);
            tab.SelectedItemIndex = 0;

            tab = new ToolBoxTab();
            tab.Caption = "Common Controls";
            toolBox1.AddTab(tab);
            items = GetCommonControls();
            items.Sort(new Comparison<ToolBoxItem>(CompareToolboxItem));
            tab.AddItem("Pointer");
            foreach (ToolBoxItem item in items)
                tab.AddItem(item);
            tab.SelectedItemIndex = 0;

            tab = new ToolBoxTab();
            tab.Caption = "Container Controls";
            toolBox1.AddTab(tab);
            items = GetContainerControls();
            items.Sort(new Comparison<ToolBoxItem>(CompareToolboxItem));
            tab.AddItem("Pointer");
            foreach (ToolBoxItem item in items)
                tab.AddItem(item);
            tab.SelectedItemIndex = 0;
        }

        private List<ToolBoxItem> GetCommonControls()
        {
            List<ToolBoxItem> items = new List<ToolBoxItem>();
            ToolBoxItem item = new ToolBoxItem();
            item.Caption = "Button";
            item.Object = typeof(ScmButton);
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "CheckBox";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "RadioBox";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "Choice";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "ListBox";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "TextField";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "Message";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "ComboField";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "Slider";
            items.Add(item);

            item = new ToolBoxItem();
            item.Caption = "Gauge";
            items.Add(item);

            return items;
        }

        private List<ToolBoxItem> GetContainerControls()
        {
            List<ToolBoxItem> items = new List<ToolBoxItem>();
            ToolBoxItem item = new ToolBoxItem();
            item.Caption = "Frame";
            item.Object = typeof(ScmFrame);
            items.Add(item);

            return items;
        }

        public int CompareToolboxItem(ToolBoxItem obj1, ToolBoxItem obj2)
        {
            return obj1.Caption.CompareTo(obj2.Caption);
        }

        private void toolBox1_ItemSelectionChanged(ToolBoxItem sender, EventArgs e)
        {
        }

    }
}
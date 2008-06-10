    using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmFrameStyle
    {
        private bool _noResizeBorder;
        private bool _noCaption;
        private bool _noSystemMenu;
        private bool _mdiChild;
        private bool _mdiParent;
        private bool _floating;

        public bool Floating
        {
            get { return _floating; }
            set { _floating = value; }
        }

        public bool MdiParent
        {
            get { return _mdiParent; }
            set { _mdiParent = value; }
        }

        public bool MdiChild
        {
            get { return _mdiChild; }
            set { _mdiChild = value; }
        }

        public bool NoSystemMenu
        {
            get { return _noSystemMenu; }
            set { _noSystemMenu = value; }
        }

        public bool NoCaption
        {
            get { return _noCaption; }
            set { _noCaption = value; }
        }

        public bool NoResizeBorder
        {
            get { return _noResizeBorder; }
            set { _noResizeBorder = value; }
        }

        public override string ToString()
        {
            string description = string.Empty;
            if (_noResizeBorder)
                description += "NoResizeBorder, ";
            if (_noCaption)
                description += "NoCaption, ";
            if (_noSystemMenu)
                description += "NoSystemMenu, ";
            if (_mdiParent)
                description += "MdiParent, ";
            if (_mdiChild)
                description += "MdiChild, ";
            if (_floating)
                description += "Floating, ";

            if (description != string.Empty)
                description = description.Remove(description.Length - 2);

            return description;
        }

        public bool HasDefaultValues()
        {
            if (_noResizeBorder)
                return false;
            if (_noCaption)
                return false;
            if (_noSystemMenu)
                return false;
            if (_mdiParent)
                return false;
            if (_mdiChild)
                return false;
            if (_floating)
                return false;
            return true;
        }

        public string ToScmCode()
        {
            string code = "(";
            if (_noResizeBorder)
                code += "no-resize-border ";
            if (_noCaption)
                code += "no-caption ";
            if (_noSystemMenu)
                code += "no-system-menu ";
            if (_mdiParent)
                code += "mdi-parent ";
            if (_mdiChild)
                code += "mdi-child ";
            if (_floating)
                code += "float ";
            code = code.TrimEnd(' ') + ")";
            return code;
        }
    }
}

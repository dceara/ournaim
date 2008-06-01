using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace SchemeGuiEditor.Projects
{
    public class ProjectFile
    {
        private string _name;
        private string _containingFolder;

        public string ContainingFolder
        {
            get { return _containingFolder; }
            set { _containingFolder = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FullPath
        {
            get { return Path.Combine(_containingFolder, _name); }
        }

        public ProjectFile(string name,string path)
        {
            _name = name;
            _containingFolder = path;
        }

        public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement el = doc.CreateElement("ProjectFile");
            XmlAttribute att = doc.CreateAttribute("name");
            att.Value = _name;
            el.Attributes.Append(att);
            return el;
        }
    }
}

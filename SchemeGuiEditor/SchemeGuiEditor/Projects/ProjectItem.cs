using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using SchemeGuiEditor.Services;

namespace SchemeGuiEditor.Projects
{
    public enum ProjectItemType
    {
        Directory,
        SourceFile,
        TextFile
    }

    public abstract class ProjectItem
    {
        private string _name;
        private string _containingFolder;
        List<ProjectDirectory> _directorys;
        List<ProjectFile> _files;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ContainingFolder
        {
            get { return _containingFolder; }
            set { _containingFolder = value; }
        }

        public List<ProjectDirectory> Directorys
        {
            get { return _directorys; }
            set { _directorys = value; }
        }
        
         public List<ProjectFile> Files
        {
            get { return _files; }
            set { _files = value; }
        }

        public ProjectItem()
        {
            _directorys = new List<ProjectDirectory>();
            _files = new List<ProjectFile>();
        }

        public ProjectItem(string name, string path)
        {
            _name = name;
            _containingFolder = path;
            _directorys = new List<ProjectDirectory>();
            _files = new List<ProjectFile>();
        }

        public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement el = doc.CreateElement(XmlElementName);
            XmlAttribute att = doc.CreateAttribute("name");
            att.Value = _name;
            el.Attributes.Append(att);
            foreach (ProjectDirectory dir in _directorys)
            {
                el.AppendChild(dir.ToXml(doc));
            }
            foreach (ProjectFile file in _files)
            {
                el.AppendChild(file.ToXml(doc));
            }
            return el;
        }

        public void FromXml(XmlElement xmlElement)
        {
            XmlNodeList dirList = xmlElement.SelectNodes("ProjectDirectory");
            foreach (XmlElement el in dirList)
            {
                string name = el.Attributes["name"].Value;
                ProjectDirectory dir = new ProjectDirectory(name, Path.Combine(_containingFolder, name));
                dir.FromXml(el);
                _directorys.Add(dir);
            }

            XmlNodeList fileList = xmlElement.SelectNodes("ProjectFile");
            foreach (XmlElement el in fileList)
            {
                ProjectFile file = new ProjectFile(el.Attributes["name"].Value, _containingFolder);
                _files.Add(file);
            }
        }

        public abstract string XmlElementName { get;}
     }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace SchemeGuiEditor.Projects
{
    public enum ProjectType
    {
        EmptyProject,
        WindowsApplication
    }

    public class Project:ProjectItem
    {
        private ProjectType _projectType;

        public Project(string name, string path,ProjectType type):base(name,path)
        {
            _projectType = type;
        }

        public string ProjectFileName
        {
            get {return Path.Combine(ContainingFolder,Name+ConstantNames.ProjectExtension);}
        }

        public override string XmlElementName
        {
            get { return "Project"; }
        }

    }
}

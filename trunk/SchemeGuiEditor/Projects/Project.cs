using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace SchemeGuiEditor.Projects
{
    public class Project:ProjectItem
    {
              
        public Project(string name, string path):base(name,path)
        {
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

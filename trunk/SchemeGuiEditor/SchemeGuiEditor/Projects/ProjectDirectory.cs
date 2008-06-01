using System;
using System.Collections.Generic;
using System.Text;
using SchemeGuiEditor.Projects;
using System.Xml;
using System.IO;
using SchemeGuiEditor.Services;

namespace SchemeGuiEditor.Projects
{
    public class ProjectDirectory:ProjectItem
    {
        public ProjectDirectory(string name, string path)
            : base(name, path)
        {
            if (!Directory.Exists(ContainingFolder))
                Directory.CreateDirectory(ContainingFolder);
        }

        public override string XmlElementName
        {
            get { return "ProjectDirectory"; }
        }
    }
}

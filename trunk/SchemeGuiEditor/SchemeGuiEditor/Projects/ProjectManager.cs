using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using SchemeGuiEditor.Services;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.Projects
{
    public sealed class ProjectManager
    {
        static readonly ProjectManager _instance = new ProjectManager();
        private Project _project = null;
        private string _projectFileName;

        public event EventHandler<DataEventArgs<Project>> ProjectChanged;

        static ProjectManager()
        {
        }

        public static ProjectManager Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool CreateProject(string projectName, string projectPath)
        {
            string path = Path.Combine(projectPath, projectName);
            _project = new Project(projectName,path);
           
            Directory.CreateDirectory(_project.ContainingFolder);
            FileStream projectFile = File.Create(_project.ProjectFileName);
            projectFile.Close();

            AddNewProjectFile("Main"+ConstantNames.SourceFileExtension, _project);

            if (ProjectChanged != null)
                ProjectChanged(this, new DataEventArgs<Project>(_project));
            return true;
        }

        public void LoadProject(string projectFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(projectFileName);
            _project = new Project(Path.GetFileNameWithoutExtension(projectFileName),
                Path.GetDirectoryName(projectFileName));
            _project.FromXml(doc.DocumentElement);
            _projectFileName = projectFileName;
            if (ProjectChanged != null)
                ProjectChanged(this, new DataEventArgs<Project>(_project));
        }

        public ProjectFile AddNewProjectFile(string name,ProjectItem projectItem)
        {
            ProjectFile file = new ProjectFile(name,projectItem.ContainingFolder);
            if (File.Exists(file.FullPath))
            {
                MessageService.ShowError(Strings.FileAlreadyExists);
                return null;

            }
            FileStream stream = File.Create(file.FullPath);
            stream.Close();
            projectItem.Files.Add(file);
            WriteProjectConfiguration();
            return file;
        }

        public ProjectDirectory AddNewProjectDirectory(ProjectItem projectItem)
        {
            string dirPath = Path.Combine(projectItem.ContainingFolder, "NewFolder");
            int i = 1;
            while (Directory.Exists(dirPath + i.ToString()))
                i++;

            ProjectDirectory dir = new ProjectDirectory("NewFolder" + i.ToString(), dirPath + i.ToString());
            projectItem.Directorys.Add(dir);
            WriteProjectConfiguration();
            return dir;
        }

        //public ProjectDirectory AddNewProjectDirectory(string name, ProjectItem projectItem)
        //{
        //    string dirPath = Path.Combine(projectItem.ContainingFolder,name);
        //    if (Directory.Exists(dir.ContainingFolder))
        //    {
        //        MessageService.ShowError(Strings.ProjectAlreadyExists);
        //        return null;
        //    }
        //    ProjectDirectory dir = new ProjectDirectory(name, dirPath);
        //    projectItem.Directorys.Add(dir);
        //    WriteProjectConfiguration();
        //    return dir;
        //}

        private void WriteProjectConfiguration()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(_project.ToXml(doc));
            doc.Save(_project.ProjectFileName);
        }


        public bool Rename(string newName, ProjectDirectory dir)
        {
            if (newName == dir.Name)
                return true;

            string newPath = Path.Combine(Directory.GetParent(dir.ContainingFolder).FullName, newName);
            if (Directory.Exists(newPath))
            {
                MessageService.ShowError(String.Format(Strings.RenameError, newName));
                return false;
            }
            Directory.Move(dir.ContainingFolder, newPath);
            dir.ContainingFolder = newPath;
            dir.Name = newName;
            WriteProjectConfiguration();
            return true;
        }
    }
}

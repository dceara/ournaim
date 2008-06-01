using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor
{
    public class ConstantNames
    {
        public const string IsolatedStorageFolder = "SchemeEditor";
        public const string SettingsFileName = "Layout.config";
        public const string ProjectExtension = ".sprj";
        public const string SourceFileExtension = ".scm";
    }

    public class Strings
    {
        public const string ProjectAlreadyExists = "The project directory already exists";
        public const string DirectoryAlreadyExists = "A directory with that name already exists";
        public const string FileAlreadyExists = "File already exists";
        public const string FileNotFound = "Can not load file {0}. File has been renamed or deleted";
        public const string DirectoryNotFound = "Can not find path {0}. Folder has been renamed or deleted";
        public const string RenameError = "A file or folder with the name \"{0}\" already exists on disk at this location. Please choose another name.";
    }
}

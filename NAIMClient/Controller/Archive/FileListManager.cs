using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Controller.Archive
{
    public class FileListManager
    {
        #region Constants

        const string _fileListLocation = "FileLists";

        #endregion

        #region Fields And Properties

        private string _currentDir;

        private string _userName;

        public string UserName
        {
            set 
            { 
                _userName = value;
                LoadFileList(value);
            }
        }

        private IList<KeyValuePair<int, KeyValuePair<string, string>>> _fileList;

        public IList<KeyValuePair<int, KeyValuePair<string, string>>> FileList
        {
            get
            {
                return _fileList;
            }
        }

        #endregion

        #region Constructors

        public FileListManager()
        {
            _currentDir = Directory.GetCurrentDirectory();
            if (!Directory.Exists(_fileListLocation))
            {
                Directory.CreateDirectory(_fileListLocation);
            }
        }

        #endregion

        #region Private Methods

        private void LoadFileList(string uname)
        {
            _fileList = new List<KeyValuePair<int, KeyValuePair<string, string>>>();
            string fileListFilename = _currentDir + "\\" + _fileListLocation + "\\" + uname;
            if (!File.Exists(fileListFilename))
            {
                File.Create(fileListFilename);
                return;
            }
            StreamReader reader = new StreamReader(fileListFilename);
            int cnt = 0;
            while (!reader.EndOfStream)
            {
                string id = reader.ReadLine();
                string realPath = reader.ReadLine() ;
                string alias = reader.ReadLine() ;
                if(File.Exists(realPath))
                    _fileList.Add(new KeyValuePair<int, KeyValuePair<string, string>>(cnt++, new KeyValuePair<string, string>(realPath, alias)));
            }
            reader.Close();
        }

        #endregion

        #region Public Methods

        public void SaveFileList()
        {
            if (_fileList == null)
                return;
            string fileListFilename = _currentDir + "\\" + _fileListLocation + "\\" + _userName;
            StreamWriter writer = new StreamWriter(fileListFilename);
            int i = 0;
            foreach (KeyValuePair<int, KeyValuePair<string, string>> pair in _fileList)
            {
                writer.WriteLine(i++);
                writer.WriteLine(pair.Value.Key.ToString());
                writer.WriteLine(pair.Value.Value.ToString());
            }
            writer.Close();
        }

        #endregion
    }
}

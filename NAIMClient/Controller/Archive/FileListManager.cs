using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Controller.Archive
{
    public class FileListManager
    {
        const string _fileListLocation = "FileLists";

        private string _userName;

        public string UserName
        {
            set 
            { 
                _userName = value;
                LoadFileList(value);
            }
        }

        public FileListManager()
        {
        }

        private IList<KeyValuePair<int,KeyValuePair<string,string>>> _fileList;

        public IList<KeyValuePair<int,KeyValuePair<string,string>>> FileList
        {
            get
            {
                return _fileList;
            }
        }

        private void LoadFileList(string uname)
        {
            string fileListFilename = _fileListLocation + "\\" + uname;
            if(!File.Exists(fileListFilename))
            {
                File.Create(fileListFilename);
            }
            StreamReader reader = new StreamReader(fileListFilename);
            _fileList = new List<KeyValuePair<int, KeyValuePair<string, string>>>();
            while (!reader.EndOfStream)
            {
                string id = reader.ReadLine();
                string realPath = reader.ReadLine() ;
                string alias = reader.ReadLine() ;
                _fileList.Add(new KeyValuePair<int, KeyValuePair<string, string>>(int.Parse(id), new KeyValuePair<string, string>(realPath, alias)));
            }
            reader.Close();
        }

        public void SaveFileList()
        {
            if (_fileList == null)
                return;
            string fileListFilename = _fileListLocation + "\\" + _userName;
            if (!File.Exists(fileListFilename))
            {
                File.Create(fileListFilename);
            }
            StreamWriter writer = new StreamWriter(fileListFilename);
            foreach (KeyValuePair<int, KeyValuePair<string, string>> pair in _fileList)
            {
                writer.WriteLine(pair.Key.ToString());
                writer.WriteLine(pair.Value.Key.ToString());
                writer.WriteLine(pair.Value.Value.ToString());
            }
            writer.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Common.Protocol;

namespace Controller.Archive
{
    public class ArchiveManager
    {
        const string _archiveLocation = "Archive";

        private string _userName;

        private string _currentUserFolder;

        public string UserName
        {
            set 
            {
                _userName = value;
                _currentUserFolder = _archiveLocation + "\\" + _userName;
                CreateUserFolder(value);
            }
        }

        public ArchiveManager()
        {
        }

        public void SaveMessage(string contact, string message)
        {
            FileStream archiveStream;
            if(!File.Exists(_currentUserFolder+"\\"+contact))
            {
                archiveStream = new FileStream(_currentUserFolder + "\\" + contact, FileMode.Create);
            }
            else
            {
                archiveStream = new FileStream(_currentUserFolder + "\\" + contact, FileMode.Append);
            }
            byte[] date = AMessageData.ToByteArray(DateTime.Now.ToString()+"\r\n");
            byte[] toWrite = AMessageData.ToByteArray(message+"\r\n");
            archiveStream.Write(date, 0, date.Length);
            archiveStream.Write(toWrite, 0, toWrite.Length);
            archiveStream.Close();
        }

        public IList<KeyValuePair<string, IList<string>>> GetMessageArchive()
        {
            IList<KeyValuePair<string,IList<string>>> toReturn = new List<KeyValuePair<string,IList<string>>>();
            DirectoryInfo dirInfo = new DirectoryInfo(_currentUserFolder);
            FileInfo[] fileInfos = dirInfo.GetFiles();
            foreach (FileInfo info in fileInfos)
            {
                string contactName = info.Name;
                IList<string> value = new List<string>();
                StreamReader textReader = File.OpenText(_currentUserFolder + "\\" + contactName);
                while(!textReader.EndOfStream)
                {
                    string dateString = textReader.ReadLine();
                    string messageString = textReader.ReadLine();
                    value.Add(dateString + ": " + messageString);
                }
                textReader.Close();
                toReturn.Add(new KeyValuePair<string,IList<string>>(contactName,value));
            }
            return toReturn;
        }

        private void CreateUserFolder(string vlue)
        {
            if (!Directory.Exists(_currentUserFolder))
            {
                Directory.CreateDirectory(_currentUserFolder);
            }
        }


    }
}

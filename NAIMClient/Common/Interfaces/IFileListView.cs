using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public delegate void AddFileDelegate(string name, string alias);

    public delegate void RemoveFileDelegate(string name);

    public interface IFileListView
    {
        event AddFileDelegate AddFileEvent;

        void OnAddFile(string name, string alias);

        event RemoveFileDelegate RemoveFileEvent;

        void OnRemoveFile(string name);

        void ShowView();

        void Initialise(IList<KeyValuePair<int, KeyValuePair<string, string>>> fileList);
    }
}

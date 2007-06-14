using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IArchiveView
    {
        void ShowDialog(IList<KeyValuePair<string, IList<string>>> archive, string contactName);
    }
}

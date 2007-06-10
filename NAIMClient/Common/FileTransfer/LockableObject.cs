using System;
using System.Collections.Generic;
using System.Text;

namespace Common.File_Transfer
{
    /// <summary>
    /// This is used so base types can be locked in multi-threading.
    /// </summary>
    
    public class LockableObject<T>
    {
        #region Properties
        private T _innerValue;

        public T Value
        {
            get { return _innerValue; }
            set { _innerValue = value; }
        }

        #endregion

        #region Constructor

        public LockableObject(T value)
        {
            _innerValue = value;
        }
        #endregion
    }
}

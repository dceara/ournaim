using System;
using System.Collections.Generic;
using System.Text;

namespace Common.File_Transfer
{
    public class LockableBool
    {
        private bool _innerValue;

        public bool Value
        {
            get { return _innerValue; }
            set { _innerValue = value; }
        }

        public LockableBool(bool value)
        {
            _innerValue = value;
        }
	
    }
}

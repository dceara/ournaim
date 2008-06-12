using System;
using System.Collections.Generic;
using System.Text;

namespace SchemeGuiEditor.Utils
{
    public class DataEventArgs<TData> : EventArgs
    {
        TData data;

        /// <summary>
        /// Initializes the DataEventArgs class.
        /// </summary>
        /// <param name="data">Information related to the event.</param>
        /// <exception cref="ArgumentNullException">The data is null.</exception>
        private DataEventArgs()
        {
        }

        public DataEventArgs(TData data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets the information related to the event.
        /// </summary>
        public TData Data
        {
            get { return data; }
        }

        /// <summary>
        /// Provides a string representation of the argument data.
        /// </summary>
        public override string ToString()
        {
            return data.ToString();
        }
    }
}

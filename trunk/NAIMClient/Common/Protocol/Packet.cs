using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Protocol
{
    public class Packet
    {
        private string header;
        private ServiceType service;
        private int length;
        private byte[] content;

        public string Header
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ServiceType Service
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Length
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public byte[] Content
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}

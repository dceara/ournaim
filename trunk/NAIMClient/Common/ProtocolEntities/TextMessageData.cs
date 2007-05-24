using System;
using System.Collections.Generic;
using System.Text;
using Common.Protocol;

namespace Common.ProtocolEntities
{
    public class TextMessageData:AMessageData
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
	
        private string _sender;

	    public string Sender
	    {
		    get { return _sender;}
		    set { _sender = value;}
	    }

        private string _receiver;

        public string Receiver
            {
            get { return _receiver; }
            set { _receiver = value; }
        }
	

        public TextMessageData(string sender,string receiver, string text)
        {
            _sender = sender;
            _receiver = receiver;
            _text = text;
        }

        public TextMessageData(byte[] data)
            :base(data)
        {
        }
        protected override void Deserialize()
        {
            int senderLen = _data[0];
            int receiverLen = _data[senderLen + 1];
            int textLen = _data[senderLen + receiverLen + 2];
            _sender = AMessageData.ToString(_data, 1, senderLen);
            _receiver = AMessageData.ToString(_data, senderLen + 2, receiverLen);
            _text = AMessageData.ToString(_data, senderLen + receiverLen + 3, textLen);
        }

        public override byte[] Serialize()
        {
            byte[] sender = AMessageData.ToByteArray(_sender);
            byte[] receiver = AMessageData.ToByteArray(_receiver);
            byte[] text = AMessageData.ToByteArray(_text);
            byte senderLen = (byte)sender.Length;
            byte receiverLen = (byte)receiver.Length;
            byte textLen = (byte)text.Length;
            byte[] toReturn = new byte[senderLen + receiverLen + textLen + 3];
            toReturn[0] = senderLen;
            toReturn[senderLen + 1] = receiverLen;
            toReturn[senderLen + receiverLen + 2] = textLen;
            Array.Copy(sender, 0, toReturn, 1, senderLen);
            Array.Copy(receiver, 0, toReturn, senderLen + 2, receiverLen);
            Array.Copy(text, 0, toReturn, senderLen + receiverLen + 3, textLen);
            return toReturn;
        }
    }
}

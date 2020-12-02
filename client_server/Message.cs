using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace client_server
{
    [Serializable]
    public class Message
    {
        public string sender;
        public string message;

        [NonSerialized]
        static BinaryFormatter formatter = new BinaryFormatter();

        public static Message BytesToMessage(byte[] message)
        {        
            using (var stream = new MemoryStream(message))
            {
                return formatter.Deserialize(stream) as Message;
            }  
        }

        public byte[] MessageToBytes()
        {
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                return stream.ToArray();
            }    
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationHelper
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public CommunicationHelper(Socket soket)
        {
            stream = new NetworkStream(soket);
            formatter = new BinaryFormatter();
        }

        public T Primi<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }

        public void Posalji<T>(T objekat) where T : class
        {
            formatter.Serialize(stream,objekat);
        }
    }
}

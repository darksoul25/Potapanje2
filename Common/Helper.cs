using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Helper
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;
        private Socket soket;
        public Helper(Socket soket)
        {
            this.soket = soket;
            stream = new NetworkStream(soket);
            formatter = new BinaryFormatter();  
        }
        public void Send<T>(T obj)where T : class
        {
            formatter.Serialize(stream, obj);

        }
        public T Receive<T>()where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}

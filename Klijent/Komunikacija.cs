using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        public static Komunikacija Instance
        {
            get
            {
                if(instance == null)
                    instance = new Komunikacija();
                return instance;
            }
        }
        private Komunikacija()
        {
            
        }
        private Socket soket;
        private Helper helper;
        public bool Connect()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("127.0.0.1", 9999);
                helper = new Helper(soket);
                return true;
            }
            catch (SocketException e)
            {
                Console.WriteLine(">>>"+e.Message);
                return false ;
            }

        }

        internal void Pokusaj(Poruka p)
        {
            helper.Send(p);
        }

        internal Poruka PrimiOdg()
        {
            return helper.Receive<Poruka>();
        }

        internal void Stop()
        {
            //soket.Shutdown(SocketShutdown.Both);
            soket.Close();
            soket=null;
        }
    }
}

using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        public static List<User> useri = new List<User>()
        {
                new User
                {
                    Ime="Pera",
                    Prezime="Peric",
                    Email="pera@gmail.com",
                    Password="p"
                },
                new User
                {
                    Ime="Zika",
                    Prezime="Zikic",
                    Email="zika@gmail.com",
                    Password="z"
                }
        };
        private Socket osluskujuciSoket;
        public Server()
        {

        }
        public void Pokreni()
        {
            try
            {
                osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                osluskujuciSoket.Bind(endPoint);
                osluskujuciSoket.Listen(5);
            }
            catch (SocketException e)
            {
                System.Windows.Forms.MessageBox.Show(">>>"+e.Message);
            }

        }
        Igrac igrac;
        public void PoveziIgraca()
        {
            
            try
            {
                Socket soketIgrac = osluskujuciSoket.Accept();
                igrac = new Igrac(soketIgrac);
                while (true)
                {
                    Poruka p = igrac.Pokusaj();
                    if (p.Operacija == Operacija.Pokusaj)
                    {
                        p=Form1.Proveri(p);
                        igrac.Odgovor(p);    
                    }
                    else if(p.Operacija== Operacija.Kraj)
                    {
                        break;
                    }
                   
                }
            }
            catch (SocketException e)
            {

                Debug.WriteLine(">>>" + e.Message);
            }
        }
        public void Stop()
        {
            osluskujuciSoket.Close();
            osluskujuciSoket=null;
        }
    }
}

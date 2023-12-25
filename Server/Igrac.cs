using Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Igrac
    {
        private Helper helper;
        private Socket soket;
        public Igrac(Socket soket)
        {
            this.soket = soket;
            helper = new Helper(soket);
        }

        internal void Odgovor(Poruka p)
        {
            helper.Send(p);
        }

        internal Poruka Pokusaj()
        {
            return helper.Receive<Poruka>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Poruka
    {
        public int Broj { get; set; }
        public int Pozicija { get; set; }
        public Operacija Operacija { get; set; }
        public bool Pogodak { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{
    class pilota
    {
        private string nev;
        private DateTime datum;
        private string nemzetiseg;
        private int rajtszam;

        public pilota(string nev, DateTime datum, string nemzetiseg, int rajtszam)
        {
            this.Nev = nev;
            this.Datum = datum;
            this.Nemzetiseg = nemzetiseg;
            this.Rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public int Rajtszam { get => rajtszam; set => rajtszam = value; }
    }
}

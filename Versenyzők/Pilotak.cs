using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{
    class Pilotak
    {
        private List<pilota> pilotaLista = new List<pilota>();
        public Pilotak(string filenev) {
            StreamReader sr = new StreamReader(filenev);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {               
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                string nev = adatok[0];
                DateTime datum = DateTime.Parse(adatok[1]);
                string nemzetiseg = adatok[2];
                int rajtszam = 0;
                pilota ujPilota = null;
                if (String.IsNullOrWhiteSpace(adatok[3]))
                {
                    rajtszam = 0;
                    ujPilota = new pilota(nev, datum, nemzetiseg, rajtszam);

                }
                else {
                    rajtszam = Convert.ToInt32(adatok[3]);
                    ujPilota = new pilota(nev, datum, nemzetiseg, rajtszam);
                }
                
                pilotaLista.Add(ujPilota);
                
            }
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Console.ReadKey();
        }

     

        public void Feladat3() {
            Console.WriteLine("3. feladat: "+ pilotaLista.Count);
        }
        public void Feladat4() {
            string nev = "";
            foreach (pilota item in pilotaLista)
            {
                nev = item.Nev;
            }
            Console.WriteLine("4. feladat: "+ nev);
        }
        private void Feladat5(){
            var dt = DateTime.Parse("1901.01.01");
            Console.WriteLine("5. feladat:");
            foreach (pilota item in pilotaLista)
            {
                if (dt > item.Datum)
                {
                    Console.WriteLine("\t"+item.Nev +"("+item.Datum+")" );
                }
            }

            }
        private void Feladat6() {
            int maxrajtszam = 0;
            int temp = 0;
            string maxnemzetiseg = "";
            foreach (pilota item in pilotaLista)
            {
                temp = item.Rajtszam;
                if (maxrajtszam<item.Rajtszam)
                {
                    maxrajtszam = item.Rajtszam;
                    maxnemzetiseg = item.Nemzetiseg;
                }

            }
            Console.WriteLine("6. feladat: "+ maxnemzetiseg);
        } 

        private void Feladat7() {
            //Dictionary<int, int> countOfItems = new Dictionary<int, int>();
            //foreach (pilota item in pilotaLista)
            //{
            //    if (countOfItems.ContainsKey(item.Rajtszam))
            //    {
            //        countOfItems[item.Rajtszam]++;
            //    }
            //    else {
            //        countOfItems[item.Rajtszam] = 1; 
            //    }
            //}
            Console.Write("Repeated Elements are :");

            for (int i = 0; i < pilotaLista.Count; i++)
            {

                for (int j = i+1; j < pilotaLista.Count; j++)
                {
                    if (pilotaLista[i].Rajtszam == pilotaLista[j].Rajtszam)
                    {
                        Console.WriteLine(pilotaLista[i].Rajtszam+ " ");
                    }
                }
            }
                
            



        }
    }
}

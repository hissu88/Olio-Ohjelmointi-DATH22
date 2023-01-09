using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olliohjelmointi
{
    internal class Class2
    {
        public string Nimi;
        public string Rotu;
        public int Ika;

        public Class2(string nimi, string rotu, int ika)
        {
            Nimi = nimi;
            Rotu = rotu;
            Ika = ika;
        }

        public void haetiedot()
        {
            Console.WriteLine("koiran ´nimi on " + Nimi);
            Console.WriteLine("koiran ikä on " + Ika);
            Console.WriteLine("koiran rotu on " + Rotu);
        }
        public void hauku()
        {
            Console.WriteLine("woof woof");
        }
    }
}
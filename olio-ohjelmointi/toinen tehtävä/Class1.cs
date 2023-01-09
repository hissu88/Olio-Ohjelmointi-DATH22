using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toinen_tehtävä
{
    internal class Class1
    {
        public string Name;
        public string Id;
        public int Pisteet;

        public Class1(string name, string id, int pisteet)
        {
            Name = name;
            Id = id;
            Pisteet = pisteet;
        }
        public void lisaaopintopisteet(int määrä)
        {
            Pisteet += määrä;

        }
        public void TulostaData()
        {
            Console.WriteLine("oppilaan nimi " + Name + " ja oppilaan id " + Id);
            Console.WriteLine("opintopisteet " + Pisteet);

        }
    }
}

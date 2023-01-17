using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Class1> Cards = new Dictionary<string, Class1>();


            Class1 pata = new Class1("pata");
            Class1 hertta = new Class1("hertta");
            Class1 ruutu = new Class1("ruutu");
            Class1 risti = new Class1("risti");
            
            foreach (string pata in Cards.Keys)
                Console.WriteLine("-tunnus:" + Cards[pata].tunnus);

        }
    }
}

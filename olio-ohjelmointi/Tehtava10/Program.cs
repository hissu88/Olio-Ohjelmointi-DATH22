using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tehtava10.Class1;

namespace Tehtava10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> Henkilösanakirja = new Dictionary<string, Person>();


            Person juho = new Person("2345-6531", "juho", "B12");
            Henkilösanakirja.Add(juho.henkilöId, juho);
            Person aleksi = new Person("24221-3241", "aleksi", "B12");
            Henkilösanakirja.Add(aleksi.henkilöId, aleksi);
            Console.WriteLine("henkilösanakirja " + Henkilösanakirja.Count);
            Console.WriteLine();
        
            foreach (string henkilöId in Henkilösanakirja.Keys)
            {
                Console.WriteLine("henkilön tiedot ");
                Console.WriteLine("-hetu:" + Henkilösanakirja[henkilöId].Name);
                Console.WriteLine("-hetu:" + Henkilösanakirja[henkilöId].henkilöId);
                Console.WriteLine("-tunnus:" + Henkilösanakirja[henkilöId].tunnus);

            }
        }
    }
}
    
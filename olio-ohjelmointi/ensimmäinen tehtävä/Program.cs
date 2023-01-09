using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensimmäinen_tehtävä
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ajoneuvo auto = new ajoneuvo("mersu", 120, 4);

            auto.TulostaData();
        }
    }
}

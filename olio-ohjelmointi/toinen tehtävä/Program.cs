using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toinen_tehtävä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 opiskelia = new Class1("aleksi", "ID", 120);
            opiskelia.TulostaData();
            opiskelia.lisaaopintopisteet(5);
            opiskelia.TulostaData();

        }
    }
}

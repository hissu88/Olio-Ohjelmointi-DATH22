using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olliohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 koira = new Class2("rekku", "paimenkoira", 12);
           
          
            koira.haetiedot();

            Class2 koira1 = new Class2("ali", "cockerspaneli", 3);
            koira.haetiedot();
            koira.hauku();


        }
    }
}

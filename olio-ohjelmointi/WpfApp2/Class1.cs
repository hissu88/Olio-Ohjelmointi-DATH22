using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class ajoneuvo

    {
        public string Merkki;
        public int Nopeus;
        public int Renkaat;

       

        public string HaeData()
        {
            return Merkki + " ajoneuvolla on  " + Renkaat + " ja on" + Nopeus + "nopea";
            
        }
    }
}

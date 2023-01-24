using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtäviä
{
    internal class ajoneuvo
    {
        public string Model;
        public int Tyres;
        public int Speed;

      public string Haetiedot()
        {
            return Model+ " on malli ja autossa on " + Tyres + " rengasta ja auton nopeus on " + Speed;
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiuas
{
    internal class Class1
    {
        public bool Onkopaalla;
        public int Lampo;
        public int Kosteus;

   
        public void tulosta()
        {
            Console.WriteLine("kiuas on " + Onkopaalla);
            Console.WriteLine("lämpöä on " + Lampo);   
            Console.WriteLine("kosteus on " + Kosteus); 


        }
        public void muokkaakosteutta(int määrä)
        {
            Kosteus = määrä;
        }
        public void muokkaalämpö(int määrä)
        {
            Lampo = määrä;
        }
    }

}

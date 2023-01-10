using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laskindd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float summa;
            summa = laskin.Summa(10, 1);
            Console.WriteLine(summa);
            float kerto;
            kerto = laskin.kerto(10, 1);
            Console.WriteLine(kerto);
            float jako;
            jako = laskin.jako(10, 2);
            Console.WriteLine(jako);
            float erotus;
            erotus = laskin.erotus(10, 1);
            Console.WriteLine(erotus);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hissi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hissi hissi = new hissi();
            hissi.Kerros = 9;
            Console.WriteLine("hissi "+hissi.Kerros.ToString());
        }
    }
}

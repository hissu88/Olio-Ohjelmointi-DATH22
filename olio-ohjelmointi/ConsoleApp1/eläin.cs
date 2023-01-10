using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
class eläin
{
    static void Main(string[] args)
    {
          
            elain myanimal = new elain();
            elain1 myanima11 = new elain1();

            myanimal.honk();
            myanima11.honk();

            
            Console.WriteLine(myanimal.brand + " " + myanimal.modelName + " " + myanimal.maara);
            Console.WriteLine(myanima11.brand + " " + myanima11.modelName +" "+ myanimal.maara);
        }
    }
}

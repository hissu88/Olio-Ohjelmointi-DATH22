using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{

    class animal  // base class (parent) 
    {
        public string brand = "mammal";  
        
        public void honk()            
        {
            Console.WriteLine("Tuut, tuut!");
        }

    }
}

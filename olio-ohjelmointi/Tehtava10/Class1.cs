using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava10
{
    internal class Class1
    {
        public class Person
        {
            public string Name { get; set; }
            public string henkilöId { get; set; }

            public string tunnus { get; set; }
            public Person(string name, string HenkilöId, string Tunnus)
            {
                Name = name;
                henkilöId = HenkilöId;
                tunnus = Tunnus;
            }

        }
    }
}

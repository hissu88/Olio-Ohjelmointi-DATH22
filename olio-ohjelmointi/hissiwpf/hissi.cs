using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hissiwpf
{
    class hissi
    {

        private int kerros;
        public int Kerros
        {
            get { return kerros; }
            set
            {
                kerros = value;

                if (kerros < 1)
                {
                    kerros = 1;
                }
                else if (kerros > 7)
                {
                    kerros = 7;
                }

            }

        }


    }
}

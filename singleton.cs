using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class singleton
    {

        private static int licznik = 0;
        private static singleton obiekt = null; 

        public static singleton wczytaj
        {
            get
            {
                if( obiekt == null)
                {
                    obiekt = new singleton(); 
                }
                return obiekt; 
            }
        }


        private singleton()
        {
            licznik += 1;
            Console.WriteLine("Licznik wynosi: {0} ", licznik); 

        }

    }


}

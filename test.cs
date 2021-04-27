using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class test
    {

        private float kolejna;
        private int nowa; 
        private static DateTime first_U;
        private static test jeden;
        private const int liczba = 34;
        private static int licznik;
        private readonly int next;
        

        public static test rob_testowa()
        {
            if (jeden == null)
            {
                jeden = new test(); 
            }
            return jeden; 
        }


        public int pokaz_obiekty()
        {
            return licznik; 
            
        }

        public static test zrob_obiekt()
        {
            test ob = new test();
            return ob; 
        }

        public int pokaz ()
        {
            Console.WriteLine("Czas stworzenia obiektu: " + first_U);
            return next;
        }
        public int funkcyjka ( out int aa, out int bb)
        {
            aa = 23;
            bb = 15;
            return aa * bb; 
        }

        private test()
        {
            nowa = 1;
            next = 23;
            licznik++; 

        }

        static test()
        {
            first_U = DateTime.Now; 


        }

        public test(int wart):this(wart,0)
        {
            nowa = wart;
            next = 12;
            first_U = DateTime.Now;
            licznik++; 
        }

    public test(int aa, float next)
        {
            nowa = aa;
            kolejna = next; 
        }

        //singleton 

    }
}

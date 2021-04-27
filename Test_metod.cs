using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class Test_metod
    {

        private int pi1 { get; set; }
        private int pi2 { get; set; }

        private float pf1 { get; set; }
        private float pf2 { get; set; }



        public static float dzielenie(int x, int y, out float reszta)
        {
            float wynik;
            wynik = x / y;
            reszta = x % y;

            return wynik;

        }

        public static int dodawanie_ze_zmiana(int a, int b)
        {
            int dod;
            b = b + 101;
            dod = a + b;
            return dod;
        }


    }
}

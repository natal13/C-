using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_2
{
    class Kadra: Osoba
    {

        string wykształcenie, stanowisko;

        public void wyswietl1()
        {
  
            wyswietl();

            Console.WriteLine("\r\nNo i to jest właśnie ten moment." +
                "\r\nPoprosimy różwnież o dodatkowe dane, by sklasyfikować naszą kadrę. A są to: " +
                "\r\nWykształcenie oraz Stanowisko\r\n");
            wczytaj1(); 

            Console.WriteLine("\r\nWykształcenie: {0}", wykształcenie);
            Console.WriteLine("Stanowisko: {0}", stanowisko);

        }

        private void wczytaj1()
        {
            wykształcenie = Console.ReadLine();
            stanowisko = Console.ReadLine();

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_2
{
    class Osoba
    {
        string nazwisko, imie;
        string ulica, miasto;
        string kod; 
         public void wyswietl()
        {
            
            wczytaj();

            Console.WriteLine("\r\nPodana dane to: ");
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Ulica: {0}", ulica);
            Console.WriteLine("Kod pocztowy i miasto: {0}, {1}", kod, miasto); 
        }

        public void wczytaj()
        {
            imie = Console.ReadLine();
            nazwisko = Console.ReadLine();
            ulica = Console.ReadLine();
            kod = Console.ReadLine();
            miasto = Console.ReadLine();
           
        }


       




    }
}

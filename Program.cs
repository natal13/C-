using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dzień dobry użytkowniku!\r\n");

            // TABLICA KROTEK
            int R;
            Console.WriteLine("Podaj rozmiar tablicy: ");
            R = int.Parse(Console.ReadLine());

            var tab_k = new (string nazwisko_k, string imie_k, int nr_id_k)[R];


            //INICJALIZATOR 
            Osoba czlowiek = new Osoba
            {
                nazwisko = "Nowak",
                imie = "Julian",
                ulica = "Mickiewicza",
                numer = 15,
                kod = "30-053",
                miasto = "Kraków"
            };
            



            Console.ReadKey();



        }
    }
}

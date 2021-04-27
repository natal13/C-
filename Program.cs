using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Program
    {
        /**/
        public static float Dzielenie(int x, int y, out int reszta)
        {
            reszta = x % y; 
            return  x / y; 
        }

        public static int zmiana(out int aa, out int bb)
        {
            aa = 4; 
            bb = 2;

            return aa * bb; 
        }
        



        static void Main(string[] args)
        {
            Console.WriteLine("Dzień dobry użytkowniku!\r\n");

            //krotka 

           (string imie, string nazwisko) osoba;
            (string, string, int) wieksza_osoba;

            Console.Write("Podaj swoje imię: ");
            wieksza_osoba.Item1 = Console.ReadLine();
            Console.Write("Podaj nazwisko : "); 
            wieksza_osoba.Item2 = Console.ReadLine();
            Console.Write("Podaj wiek: ");
            wieksza_osoba.Item3 = int.Parse(Console.ReadLine()); 
           ///



            osoba = ("Paweł", "Jakiś"); //wypełniona krotka
            osoba.imie = "Jan";
            wieksza_osoba.Item1 = "aaa"; 

           // Console.WriteLine("Zawartość krotki: " + osoba);

            int  druga, wynik;
           // Console.WriteLine("Podaj wartość pierwszej liczby: ");
            //pierwsza = int.Parse(Console.ReadLine());
           // Console.WriteLine("Podaj wartość drugiej liczby: ");
            //druga = int.Parse(Console.ReadLine());

            wynik = zmiana(out int pierwsza, out druga);

            //Console.WriteLine("Wynik mnożezenia obu liczb to : " + wynik);
            //Console.WriteLine("Wartość drugiej: " + druga); 

            //*/
           
            /*Napisz program, w którym należy stworzyć tablicę krotek o 
                rozmiarze podanym przez użytkownika. 
                Krotka ma być zbudowana w następujący sposób: 
            nazwisko, imię, nr_id.*/
            // TABLICA KROTEK
            int R; 
            Console.WriteLine("Podaj rozmiar tablicy: ");
            R = int.Parse(Console.ReadLine());

            var tab_k = new (string nazwisko_k, string imie_k, int nr_id_k)[R]; 




            //string imie, nazwisko;
            //int nr_id;

            //int[] tab = new int[2];




            //Console.WriteLine("składniki krotki nowa_krotka: " /*+ nowa_krotka*/);



            //INICJALIZATOR 
            Osoba czlowiek = new Osoba { nazwisko = "Nowak", 
                imie = "Julian", ulica = "Mickiewicza", 
            numer = 15, kod = "30-053", miasto = "Kraków"}; 



            Console.ReadKey(); 




        }
    }
}

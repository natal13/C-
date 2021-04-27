using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_2
{
    class Program
    {

        static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fib(n - 2) + fib(n - 1);
            }
        }


        static void Main(string[] args)
        {


            /* 
             // #############================================================================================================================
             //                  ZADANIE 1 
             
            Console.WriteLine("Zadanie 1"); 
            Console.WriteLine("Program wypełniający losowo tablicę. ");

            int n, lewy, prawy;

            Console.WriteLine("Proszę, podaj przedział wartości wylosowanych danych: ");
            n = 100; 
            lewy = int.Parse(Console.ReadLine());
            prawy = int.Parse(Console.ReadLine());

            double[] tab = new double[n];
            double suma = 0;

            Random r = new Random();

            Console.WriteLine("A oto wypełniona tablica : ");

            for (int i = 0; i < 100; i++)
            {
                int a = r.Next(lewy, prawy);
                tab[i] = a;
                Console.WriteLine("{1}. {0}, ", tab[i], i + 1);
            }

            foreach (int i in tab)
            { 
                suma = suma + i;

            }

            Console.WriteLine("Suma wszystkich elementów tablicy jest równa: {0}.", suma);
            Console.WriteLine("\r\nWciśnij dowolny przycisk, aby skończyć już to losowanie. ");
            Console.ReadKey();
            // ============================================================================================================== ###############
            //*/

            // 

            /* 
          // #############================================================================================================================
          //               ZADANIE 2

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Program obliczający pierwiastki równania kwadratowego o postaci" +
                "\r\n ax^2 + bx + c\r\n");


            Pierwiastki rozwiaz = new Pierwiastki();
            rozwiaz.wyswietl_wynik();

            Console.WriteLine("\r\nWciśnij dowolny przycisk, aby skończyć już tą matematykę. "); 
            Console.ReadKey(); 
          // ============================================================================================================== ###############
            */

            // 

          //  /* 
            // #############================================================================================================================
            //                  ZADANIE 3     


            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Program uzupełniający tablicę ");

            Tablica stworz = new Tablica();

            //stworz.czytaj_dane(); 
            stworz.wyswietl_wynik();
            stworz.przetworz_dane();

            Console.WriteLine("\r\nWciśnij dowolny przycisk, aby opuścić wymiar z przykładem z tablicą ");
            Console.ReadKey();

            // ============================================================================================================== ###############
          //  */

            // 

            /* 
          // #############================================================================================================================
         //                  ZADANIE 4      

          Console.WriteLine("Zadanie 4");
          Console.WriteLine("Program wypisujący 10 pierwszych wyrazów ciągu Fibonacciego. ");
          int n = 10;

          for (int i = 0; i < n; i++)
          {
              fib(i);
              Console.WriteLine("{0}. {1}", i + 1, fib(i));
          }

          Console.WriteLine("Wciśnij dowolny  przycisk żeby wyjść."); 
          Console.ReadKey();

         // ============================================================================================================== ###############
           */

            // 

            /* 
              // #############================================================================================================================
             //                  ZADANIE 5 

            Console.WriteLine("Zadanie 5");
            Console.WriteLine("Program z danymi użytkownika. ");

            Osoba dane = new Osoba();

            Console.WriteLine("Podaj proszę teraz kolejno swoje dane: ");
            Console.WriteLine("Imię, \r\nNazwisko, \r\nUlicę, \r\nKod, \r\nMiasto \r\n");

            dane.wyswietl();

            Console.WriteLine(" "); 

            Console.WriteLine("Dziękujemy za skorzystanie z naszego programu. Wciśnij dowolny przycisk by wyjść");
            Console.ReadKey();

            // ============================================================================================================== ###############
             */

            // 

            /*
            // #############================================================================================================================
            //                  ZADANIE 6 

            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Program z dodatkowymi danymi użytkownika. ");

            Osoba dane = new Osoba();
            Kadra dod = new Kadra(); 

            Console.WriteLine("Podaj proszę teraz kolejno swoje dane: ");
            Console.WriteLine("Imię, \r\nNazwisko, \r\nUlicę, \r\nKod, \r\nMiasto \r\n");
            Console.WriteLine("Później będziecie Państwo proszeni o podanie dodatkowych informacji. \r\n"); 
            dod.wyswietl1();

            Console.WriteLine(" ");

            Console.WriteLine("Dziękujemy za skorzystanie z naszego programu. Wciśnij dowolny przycisk by w końcu z niego wyjść");
            Console.ReadKey();


            // ============================================================================================================== ###############
            */





        }
    }
}

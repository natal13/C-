using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_2
{
    class Tablica
    {

        int[,] tab = new int[10, 10];
        
        int suma = 0; 
        Random r = new Random();

        public void czytaj_dane()
        {
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        tab[i, j] = r.Next(1,10);
                    }
                    else
                    {
                        tab[i, j] = 0; 
                    }
                }
            }

        }

        public void przetworz_dane()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    suma = suma + tab[i, j];
                }
            }

            Console.WriteLine("\r\nA suma wszystkich elementów jest równa: {0}\r\n", suma);
        }

        public void wyswietl_wynik()
        {
            Console.WriteLine("Nasza tablica dwuwymiarowa wygląda następująco: \r\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tab[i, j] + " " );
                }
                Console.WriteLine("\r\n"); 
            }

        }

    }
}

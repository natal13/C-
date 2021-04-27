using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_2
{
    class Pierwiastki
    {

        double a, b, c; //współczynniki
        double delta = 0;
        double x1, x2; //pierwiastki 

        private void czytaj_dane()
        {
           
             

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            
            if (a == 0)
            {
                x1 = -1 * c / b;
                Console.WriteLine("\r\nWspółczynnik a jest równy zero. Nasze równanie nie jest rzędu drugiego.\r\n ");
                Console.WriteLine("Pierwiastek tego równania jest równy: {0:#.##}", x1); 
            }
            else
            {
               Console.WriteLine("Nasze równanie to: {0}x^2 + {1}x + {2}", a, b, c);
            }


        }

       private void przetworz_dane()
        {
            
            if (a != 0)
            {
                delta = b * b - 4 * a * c;
                

                switch (delta)
                {
                    case 0:
                        Console.WriteLine("Delta równania jest równa zero, a więc: ");
                        x1 = -1 * b / (2 * a);
                        Console.WriteLine("Pierwiastek tego równania wynosi: " +
                        "{0:#.##} ", x1);
                        break;

                    default:
                        if (delta > 0)
                        {
                            Console.WriteLine("Delta równania jest równa: {0:#.##}, a więc: ", delta);
                            x1 = (-1 * b + Math.Sqrt(delta) / (2 * a));
                            x2 = (-1 * b - Math.Sqrt(delta) / (2 * a));
                            Console.WriteLine("Pierwiastki równania to {0:#.##} oraz " +
                                "{1:#.##} ", x1, x2);

                        }
                        else
                        {
                            Console.WriteLine("Delta równania jest równa: {0:#.##}, a więc: ", delta);
                            Console.WriteLine("Równanie nie ma pierwiastków. ");
                        }

                        break; 
                }

            }

        }


        public void wyswietl_wynik()
        {

            Console.WriteLine("Podaj teraz potrzebne współczynniki: a, b oraz c ");
            czytaj_dane();
            if (a != 0)
            {
                Console.WriteLine("\r\nNo to przejdźmy w końcu do obliczeń. \r\n");
                przetworz_dane(); 
            }
            

        }


    }
}

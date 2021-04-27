using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    class NowaKlasa
    {

        int aa;

        public void metodka()
        {
            Console.WriteLine("jestem metoda z innej klasy!");
             
            wczytaj_liczba(); 
            Console.WriteLine("Podana liczba to : {0} ", aa);

            
        
        
        }
               
        private void wczytaj_liczba()
        {
            Console.Write("Podaj liczbę całkowitą: ");
            aa = int.Parse(Console.ReadLine()); 
        }


    }
}

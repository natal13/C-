using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            var suma = 0; 

            NowaKlasa ob = new NowaKlasa();

            KlasaTestowa nowy = new KlasaTestowa();
            nowy.metodka2(); 

            ob.metodka();
            lista.Add(45);
            lista.Add(12);
            lista.Add(4);

            Console.WriteLine("nowa lista:"); 
            for(int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]); 
            }
            
            Console.WriteLine("Lista po sortowaniu");
            lista.Sort(); 
            for (int i = 0; i< lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
              
            }

                lista.Add(21);
                lista.RemoveAt(1);
                Console.WriteLine("Lista po zmianach:");

            for (int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]); 

            }

            lista.Sort();
            Console.WriteLine("Lista po zmianach i sortowaniu:"); 
            for(int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]); 
            }

            foreach(int x in lista)
            {
                suma += x; 
            }

            Console.WriteLine("Suma wszystkich elementów: {0}", suma);
            Console.ReadKey(); 

        }
    }
}

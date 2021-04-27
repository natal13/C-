using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2
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

            Console.WriteLine("Program wypisujący 10 pierwszych wyrazów ciągu Fibonacciego. ");
            int n = 10; 

            for(int i = 0; i<n; i++)
            {
                fib(i);
                Console.WriteLine("{0}. {1}", i + 1, fib(i)) ; 
            }

            Console.ReadKey(); 

        }
    }
}

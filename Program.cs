using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,c;
            Console.WriteLine(a+" "+b);
          
            while((c = a + b) < 100)
            {          
                Console.WriteLine(" "+c);
                a = b;
                b = c;
            }
            Console.ReadLine(); 
        }
    }
}

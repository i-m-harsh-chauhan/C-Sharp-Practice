﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check Prime");
            int num,temp=0;
            num = int.Parse(Console.ReadLine());
            for(int i = 2; i<num-1;i++)
            {
                if (num % i == 0)
                    temp = temp + 1;
            }
            if (temp > 0)
            {

                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
            Console.ReadKey();
                    
        }
    }
}

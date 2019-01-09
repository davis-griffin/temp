﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {

        public static void printFizzBuzz()
        {
            for (int i=1; i < 100; i++)
            {
                Console.Write(i + " ");
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress Enter to end.");
            Console.ReadLine();
        }

    }
}

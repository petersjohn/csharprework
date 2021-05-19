﻿using System;

namespace _07_conditionals_ternary_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary expressions are conditionals that take 3 args, and evaluates a boolean to return a ...whatever
            int number = 10;

            //if else type a thing here
            if(number == 7)
            {
                Console.WriteLine("The number is 7.");
            }
            else
            {
                Console.WriteLine("The number is not 7");
            }
            string response = ((number == 7) ? "The number is 7." : "The number is not 7");
            Console.WriteLine(response);
        }
    }
}

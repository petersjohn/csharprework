﻿using System;

namespace _07_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//1
            Console.WriteLine("How are you feeling today from 1-5");
            string feelingNumber = Console.ReadLine();

            //2
            if (feelingNumber == "5")
            {
                Console.WriteLine("That's great to hear!");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Good stuff!");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("Hope things get better!");

            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Oh. Sorry to hear that.");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("Dang. We hope your day gets better!");
            }
            else
            {
                Console.WriteLine("Sorry, we don't understand. Come back later.");
            }
            Console.ReadLine();*/

            bool isOn = true;
            bool isHot = false;

            if(isOn)
            {
                Console.WriteLine("The light is on, it's bright.");
            }
            if (isOn == true);
            {
                Console.WriteLine("The light is on.");
            }
            if (isOn && isHot)
            {
                Console.WriteLine("light's on and it's hot.");
            }
            if (isOn || isHot)
            {
                Console.WriteLine("light's on OR it is hot");
            }
            if (!isHot)
            {
                Console.WriteLine("it's not hot (like me :(");
            }
        }    
    }
}

using System;

namespace _07_consitionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            //2
            switch (inputName)
            {
                case "fred": //this is similar to check using "=="
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    //4
                    break;
                case "karl":
                    Console.WriteLine("Let's hang.");
                    break;
                case "john":
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default:
                    Console.WriteLine("Hey" + inputName + ", can I call you back in a minute?");
                    break;
            }
        }
        //5
    }
}

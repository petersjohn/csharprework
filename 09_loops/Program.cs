using System;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop.
            //1
            /*
            int number = 0; //this is the LCV
            while(number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;

            }
            //5
            Console.ReadLine();
            */

            //for loop
            int number = 100;
            for(int i = 1; i <= number; i++) //i is the LCV, the "++" indicates increment by 1
            {
                Console.WriteLine(i);
            }

        }
    }
}

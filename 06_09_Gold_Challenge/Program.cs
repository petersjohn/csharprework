using System;

namespace _06_09_Gold_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            while (cnt < 100)
            {
                cnt++;
                //if ((cnt % 5 == 0) && (cnt % 3 == 0))
                if (cnt % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                 
               
                else if ((cnt % 3) < 1)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((cnt % 5) < 1)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(cnt);
                }
                
            }







        }
    }
 
}


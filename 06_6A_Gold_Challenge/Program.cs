using System;

namespace _06_6A_Gold_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //does ReadLine accept input?  convert.ToInt16 converts 16 bit integer value, which is fine for 1 - 20
            Console.WriteLine("Can you guess what number I am thinking of? It is between 1 and 20");
            //the number is 18
            int guessNumber = Convert.ToInt16(Console.ReadLine());
            if (guessNumber <= 10 && guessNumber > 1)
            {
                Console.WriteLine("You need to guess higher number.");
            }
            else if (guessNumber < 18)
            {
                Console.WriteLine("You're getting closer");
            }
            else if (guessNumber > 18 && guessNumber < 20)
            {
                Console.WriteLine("Juuuuuuust a bit too high.");
            }
            else if (guessNumber == 18)
            {
                Console.WriteLine("You win buddy!");
            }
            else
            {
                Console.WriteLine("COME ON, MAN!");
            }
        }
    }
}

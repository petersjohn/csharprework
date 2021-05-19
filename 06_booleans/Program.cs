using System;

namespace _06_booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isSad = false;
            //bool isHappy = true;

            //Comparison/Relational and Logical Operators
            //note an Exclusive or means that one of the two variable has to be true, in order to return a true, but NOT both.
            //Inclusive means one or both variables can be true and return a true value.

            // == equality
            // != inequality
            // < less than
            // > greater than
            // && and
            // || or (inclusive)
            // ^ XOR (exclusive)


            int value = 100 / 2;
            
            if (value == 50)
            {
                Console.WriteLine(true);

            }
            Console.WriteLine("Since I am not in the block, I will always display.");
        }     
    }
}

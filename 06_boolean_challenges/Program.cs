using System;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 101 / 2;

            if (value == 50 && (value % 2) > 0)
            {
                Console.WriteLine("***Challenge Example:***");
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);
            }

            //int value1 = 100 / 3;

            /*if (value1 != 50)
            {
                Console.WriteLine("***Bronze Challenge***");
                Console.WriteLine(false);

            }*/




        }
    }
}

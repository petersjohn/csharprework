using System;

namespace _08_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bill = 54.23m;
            decimal tip = 12;

            decimal percentage = tip / bill;

            Console.WriteLine(percentage);
            Console.WriteLine(Math.Round(percentage, 2));
            Console.WriteLine(Math.Round((percentage * 100), 2));
            Console.WriteLine("Tip Amount is $" + (Math.Round((percentage * bill), 2)));

            Console.ReadLine();
        }
    }
}

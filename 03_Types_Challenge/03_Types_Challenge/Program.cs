using System;

namespace _03_Types_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear;
            int test1 = 320000;
            int birhtMonth;

            string nameFirst= "John";
            string yob = "1974";
         
            bool earthRound = true;
            bool earthFlat;

            float mashTemp = 151.3f;
            float fermTemp;

            double piVal = 3.14159265359;
            double sqroot;

            decimal retirement = 1.34m;
            decimal dogeval;



            /*string cnvtstr = birthYear.ToString(); This method seems to be reserved for the console output?*/
            birthYear = Int32.Parse(yob);
            Console.WriteLine("I was born in {0}.", birthYear);
                    
            Console.ReadLine();

        }
    }
}

using System;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string concatenation
            string myName;
            string notMyName = "Doug";
            string first = "the cars we sell are";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + " " + second);

            //Composite formatting the number in the c braces corresponds serially to the order of the variables after
            //this seems cumbersome...?

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            //string interpolation...this is a more direct method if building a string from vars. instead of reference you are placing the var itself in the string

            string firstName1 = "Robin";
            string lastName1 = "Holler";

            Console.WriteLine($"Her name is {firstName1} {lastName1}");



        }
    }
}

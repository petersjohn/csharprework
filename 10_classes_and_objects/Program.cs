using System;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            //setting property values
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.isSpecial = true;
            dougDonut.sprinkles = "extra";

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.isSpecial = false;
            chrisDonut.sprinkles = "none";

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.isSpecial = true;
            nickDonut.sprinkles = "normal";

            Console.WriteLine(dougDonut.sprinkles);
        }
    }
}

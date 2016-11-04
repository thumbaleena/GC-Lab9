using System;

namespace LabNumber9
{
    internal class CircleApp
    {
        private static void Main(string[] args)
        {
            string radius, cont = "y";
            var count = 0;
            Console.WriteLine("Welcome to the circle tester!");

            while (cont == "y")
            {
                count = count + 1;
                Console.Write("Enter radius: ");
                radius = Console.ReadLine();
                var circle1 = new Circle(double.Parse(radius));
                Console.WriteLine();

                Console.WriteLine("Circumference: " + circle1.getFormattedCircumference());
                Console.WriteLine("Area: " + circle1.getFormattedArea());
                Console.WriteLine();

                Console.Write("Continue? (y/n) ");
                cont = Console.ReadLine().ToLower();
                switch (cont)
                {
                    case "n":
                        Console.WriteLine();
                        break;
                    case "y":
                        Console.WriteLine();
                        continue;
                    default:
                        Console.WriteLine("Invalid entry, try again.");
                        //input validation since there are only 2 right answers
                        cont = Console.ReadLine();
                        break;
                }
                while (cont != "yes" && cont != "y" && cont != "no" && cont != "n")
                {
                    Console.Write("Invalid entry. Try again! "); //input validation since there are only 2 right answers
                    cont = Console.ReadLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Goodbye. You created " + count + " Circle object(s).");
        }
    }
}

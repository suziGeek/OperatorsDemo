using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            double quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder is {remainder}");

            Console.WriteLine($"Enter A radius to calculate the area of a circle");

            var userInput = Console.ReadLine();
            var radius = Double.Parse(userInput);

            var area = AreaOfCircle(radius);

            Console.WriteLine($"{area} is the area of a circle with {radius} radius");

         

        }

        static double AreaOfCircle(double radius)
        {
           return  (Math.PI) * (radius * radius);
        }
        
    }
}

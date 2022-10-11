using System.ComponentModel;
using System.Xml.Linq;

namespace Conditional_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello stranger! What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, now you will count all numbers between x and y");
            string quit = "";
            while (quit != "X")
            {
                Console.WriteLine($"Enter X variable");
                var xAsString = Console.ReadLine();
                int x;
                while (!int.TryParse(xAsString, out x))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{name}, {xAsString} is not a number. Please enter the correct option!");
                    Console.ResetColor();
                    xAsString = Console.ReadLine();
                }
                Console.WriteLine($"Enter Y variable");
                var yAsString = Console.ReadLine();
                int y;
                while (!int.TryParse(yAsString, out y))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{name}, {yAsString} is not a number. Please enter the correct option!");
                    yAsString = Console.ReadLine();
                }
                if (x == y)
                {
                    Console.WriteLine($"Your result is {x}");
                    Console.ReadLine();
                    continue;
                }
                var minValue = Math.Min(x, y);
                var maxValue = Math.Max(x, y);

                int result = minValue;
                for (var i = minValue+1; i <= maxValue; i++)
                {
                    result = result + i;
                }
                //if (x == y)
                //{
                //    Console.WriteLine($"Your result is {y}");
                //    Console.ReadLine();
                //    continue;
                //}
                //if (x >= y) 
                //{
                //    result = x;
                //    for (var i = ++x; i <= y; i++)
                //    {
                //        result = result + i;
                //    }
                //}
                //if (x <= y)
                //{
                //    result = y;
                //    for (var i = ++y; i <= x; i++)
                //    {
                //        result = result + i;
                //    }
                //}
                Console.WriteLine($"Your result is {result}");
                Console.WriteLine($"If you want to exit the program, press X, or press any key to continue");
                quit = Console.ReadLine();
            }
        }
        
    }
}
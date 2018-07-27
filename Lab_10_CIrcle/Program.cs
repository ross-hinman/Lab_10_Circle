using System;
using Circle.Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_CIrcle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cricle Tester.");
            bool repeat = true;
            
            do
            {
                for (int i = 1; i > 0; i++)
                {

                    int counter = i;
                    Console.WriteLine("Enter Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    var circleCalc = new Circle.Library.Circle(radius);

                    var circumference = circleCalc.CalculateFormattedCircumference();
                    var area = circleCalc.CalculateFormattedArea();


                    Console.WriteLine($"Circumference: {circumference}");
                    Console.WriteLine($"Area: {area}");
                    
                    Console.WriteLine("Would you like to continue: (y/n)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        repeat = true;
                    }
                    else
                    {
                        Console.WriteLine($"You created {counter} circle object(s). Goodbye.");
                        repeat = false;
                        i = -1;
                    }
                }
            } while (repeat == true);

            
            Console.ReadKey();

        }
    }
}

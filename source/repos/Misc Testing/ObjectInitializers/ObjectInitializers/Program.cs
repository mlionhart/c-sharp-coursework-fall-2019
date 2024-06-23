using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax: *****\n");

            // Make a Point by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.Name = "firstPoint";
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a Point via a custom constructor
            Point anotherPoint = new Point("anotherPoint", 20, 20);
            anotherPoint.DisplayStats();

            // Or make a Point using object init syntax
            Point finalPoint = new Point { Name = "finalPoint", X = 30, Y = 30 };
            finalPoint.DisplayStats();

            // Calling a more interesting custom constructor with init syntax
            Point goldPoint = new Point(PointColor.Gold) { Name = "goldPoint", X = 90, Y = 20 };
            goldPoint.DisplayStats();
        }
    }
}

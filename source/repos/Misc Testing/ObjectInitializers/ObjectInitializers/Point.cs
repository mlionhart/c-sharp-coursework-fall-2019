using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    enum PointColor
    {LightBlue, BloodRed, Gold}
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name;
        public PointColor Color { get; set; }

        public Point(string name, int xVal, int yVal)
        {
            Name = name;
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point()
            : this(PointColor.BloodRed) { }

        public void DisplayStats()
        {
            Console.WriteLine("The value of point {0} is:  [{1}, {2}]", Name, X, Y);
            Console.WriteLine("Point {0} is {1}", Name, Color);
            Console.WriteLine();
        }
    }
}

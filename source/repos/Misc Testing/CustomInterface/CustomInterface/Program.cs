using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Call Points property defined by IPointy
            //Hexagon hex = new Hexagon();
            //Console.WriteLine("Points: {0}", hex.Points);
            //Console.ReadLine();

            // Can we treat hex2 as IPointy? (checking using as keyword)
            //Hexagon hex2 = new Hexagon("Peter");
            //IPointy itfPt2 = hex2 as IPointy;
            //if(itfPt2 != null)
            //    Console.WriteLine("Points: {0}", itfPt2.Points);
            //else
            //    Console.WriteLine("OOPS! Not pointy...");
            //Console.ReadLine();

            // Using is keyword
            // Make an array of Shapes
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JOJO") };

            // To be safe, you'd want to check firstPointyItem for null before processing
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            for (int i = 0; i < myShapes.Length; i++)
            {
                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves
                myShapes[i].Draw();

                // Who's pointy?
                if (myShapes[i] is IPointy ip)
                    Console.WriteLine("-> Points: {0}", ip.Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);

                // Can I draw you in 3d?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                    Console.WriteLine();
            }
            
        }
        // I'll draw anyone supporting IDraw3D.
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
            Console.WriteLine();
        }

        // This method returns the first object in the
        // array that implements IPointy
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                    return ip;
            }
            return null;
        }
    }
}

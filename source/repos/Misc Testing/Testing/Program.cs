using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] multiplicationTable = new int[4, 5];

            //// initialize the array
            //for (int i = 0; i <= 3; i++)
            //{
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        multiplicationTable[i, j] = i * j;
            //    }
            //}


            //// print max in each row
            //for (int row = 0; row <= 3; row++)
            //{
            //    //int m = multiplicationTable[row].Max();
            //    Console.Write(multiplicationTable[row, 0]); 
            //    Console.Write(multiplicationTable[row, 1]); 
            //    Console.Write(multiplicationTable[row, 2]); 
            //    Console.Write(multiplicationTable[row, 3]); 
            //    Console.Write(multiplicationTable[row, 4]);
            //    Console.WriteLine();

            //}

            //// print the array in a well-formatted manner
            //for (int row = 0; row <= 3; row++)
            //{                
            //    for (int col = 0; col <= 4; col++)
            //    {
            //        Console.Write("\t{0}", multiplicationTable[row, col]);
            //    }
            //    Console.WriteLine("\n       -----------------------------" +
            //        "----------------------------------------------------" +
            //        "-----------");
            //}
            // implicitly typed local variables
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // print out the underlying type
            Console.WriteLine("myInt is a : {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a : {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a : {0}", myString.GetType().Name);
        }
        
    }
}

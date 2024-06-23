using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // multidimensional arrays
            MultiDimensionalArrays();

            // Jagged Multidimensional Arrays - an array of arrays
            JaggedMultiDimensionalArray();

            // Pass and receive arrays as parameters
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as a return value
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        static void MultiDimensionalArrays()
        {
            // a rectangular multidimensional array
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // populate (3 * 4) array
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // print (3 * 4) array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultiDimensionalArray()
        {
            // an array of 5 arrays
            int[][] myJagArray = new int[5][];

            // create the jagged array
            for (int i = 0; i < myJagArray.Length; i++)            
                myJagArray[i] = new int[i + 7];   // creating the SIZE of each new array[1] inside array[0]            

            // print each row (remember, each element is defaulted to zero!).
            for (int i = 0; i < myJagArray[i].Length; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

    }
}

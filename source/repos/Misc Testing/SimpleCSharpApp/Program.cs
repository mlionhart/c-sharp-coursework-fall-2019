using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a simple message and wait for the Enter key to be pressed.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process any incoming args.
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg:  {0}", args[i]);
            //}

            // Using foreach
            //foreach (string arg in args)
            //{
            //    Console.WriteLine("Arg:  {0}", arg);
            //}

            // Helper method within the Program class.
            //ShowEnvironmentDetails();

            // Different ways of declaring variables
            //LocalVarDeclarations();

            // Using new to create variables
            //NewingDataTypes();

            // Data Type Functionality
            //DataTypeFunctionality();

            // Character Functionality
            CharFunctionality();

            // Wait for Enter key before shutting down
            Console.ReadLine();

            // Return an arbitrary error code
            return -1;

        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine, and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);

        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=>Data Declarations:");
            // Local variables are declared and initialized as follows:
            // dataType varName = initialValue;
            int myInt = 0;

            string myString;
            myString = "This is my character data";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();            // set to false
            int i = new int();              // set to 0
            double d = new double();        // set to 0
            DateTime dt = new DateTime();   // set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));            
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        // Field data
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        // Constructors
        public Employee() { }

        // Constructor chaining (for empAge addition)
        public Employee(string name, int id, float pay)
        :this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay)
        {
            // humm, this seems like a problem...
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }

        // methods
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }

        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        //// Accessor (get method)
        //public string GetName()
        //{
        //    return empName;
        //}

        //// mutator (set method)
        //public void SetName(string name)
        //{
        //    // Do a check on incomding value before making assignment
        //    if (name.Length > 15)
        //        Console.WriteLine("Error! Name length exceeds 15 characters!");
        //    else
        //        empName = name;            
        //}
    }
}

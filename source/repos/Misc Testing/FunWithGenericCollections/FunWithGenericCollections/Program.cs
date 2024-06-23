using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a List of Person objects, filled with
            // collection/object init syntax.
            List<Person> people = new List<Person>()
            {
                new Person {FirstName= "Homer", LastName="Simpson", Age=47 },
                new Person {FirstName= "Marge", LastName="Simpson", Age=45},
                new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
                new Person {FirstName= "Bart", LastName="Simpson", Age=8}
            };

            // print out # of items in List.
            Console.WriteLine("Items in list: {0}", people.Count);

            // Enumerate over list.
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            // Insert a new person.
            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);

            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }
            Console.WriteLine();

            // Call UseGenericQueue method
            UseGenericQueue();

        }

        // working with queues
        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseGenericQueue()
        {
            // Make a Q with three people.
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Peek at first person in Q.
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            // Remove each person from Q.
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            // Try to de-Q again?
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }
            
        }
    }
}

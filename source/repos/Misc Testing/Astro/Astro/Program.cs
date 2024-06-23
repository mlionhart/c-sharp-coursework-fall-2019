using System;

namespace Astro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("What day were you born on?");
            var day = int.Parse(Console.ReadLine());

            Console.WriteLine("What year were you born in?");
            var year = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your birth day is: {0}", day);
            Console.WriteLine("Your birth year is: {0}", year);

            if (month == "january" && day >= 22)
            {
                Console.WriteLine("you are an Aquarius.");
            }
            else if (month == "january" && day <= 21)
            {
                Console.WriteLine("you are a Capricorn");
            }
            if (month == "february" && day >= 19)
            {
                Console.WriteLine("you are an Pisces.");
            }
            else if (month == "february" && day <= 18)
            {
                Console.WriteLine("you are an Aquarius");
            }
            if (month == "march" && day >= 20)
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "march" && day <= 19)
            {
                Console.WriteLine("you are a Pisces");
            }
            if (month == "april" && day >= 20)
            {
                Console.WriteLine("you are a Taurus");
            }
            else if (month == "april" && day <= 19)
            {
                Console.WriteLine("you are an Aries");
            }
            if (month == "may" && day >= 22)
            {
                Console.WriteLine("you are a Gemini");
            }
            else if (month == "may" && day <= 21)
            {
                Console.WriteLine("you are a Taurus");
            }
            if (month == "june" && day >= 21)
            {
                Console.WriteLine("you are a Cancer.");
            }
            else if (month == "june" && day <= 20)
            {
                Console.WriteLine("you are a Gemini");
            }
            if (month == "july" && day >= 22)
            {
                Console.WriteLine("you are a Leo.");
            }
            else if (month == "july" && day <= 21)
            {
                Console.WriteLine("you are a Cancer");
            }
            if (month == "august" && day >= 23)
            {
                Console.WriteLine("you are an Virgo.");
            }
            else if (month == "august" && day <= 22)
            {
                Console.WriteLine("you are a Leo");
            }
            if (month == "september" && day >= 22)
            {
                Console.WriteLine("you are a Libra.");
            }
            else if (month == "september" && day <= 21)
            {
                Console.WriteLine("you are a Virgo");
            }
            if (month == "october" && day >= 23)
            {
                Console.WriteLine("you are an Scorpio.");
            }
            else if (month == "october" && day <= 22)
            {
                Console.WriteLine("you are a Libra");
            }
            if (month == "november" && day >= 23)
            {
                Console.WriteLine("you are an Sagittarius.");
            }
            else if (month == "november" && day <= 22)
            {
                Console.WriteLine("you are a Scorpio");
            }
            if (month == "december" && day >= 21)
            {
                Console.WriteLine("you are an Capricorn.");
            }
            else if (month == "december" && day <= 20)
            {
                Console.WriteLine("you are a Sagittarius");
            }

            // Determine Chinese Year

            var tiger = year - 1938;
            var rabbit = year - 1939;
            var dragon = year - 1940;
            var snake = year - 1941;
            var horse = year - 1942;
            var goat = year - 1943;
            var monkey = year - 1944;
            var rooster = year - 1945;
            var dog = year - 1946;
            var boar = year - 1947;
            var rat = year - 1948;
            var ox = year - 1949;

            if (tiger % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Tiger");
            }
            else if (rabbit % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Rabbit");
            }
            else if (dragon % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Dragon");
            }
            else if (snake % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Snake");
            }
            else if (horse % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Horse");
            }
            else if (goat % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Goat");
            }
            else if (monkey % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Monkey");
            }
            else if (rooster % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Rooster");
            }
            else if (dog % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Dog");
            }
            else if (boar % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Boar");
            }
            else if (rat % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Rat");
            }
            else if (ox % 12 == 0)
            {
                Console.WriteLine("you were born in the year of the Ox");
            }
        }
    }
}

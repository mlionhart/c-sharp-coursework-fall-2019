using System;

namespace AstroSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();          

            Console.WriteLine("What is your age?");
            var age = TryAnswer();            

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();
            
            Console.WriteLine("What day were you born on?");
            var day = TryAnswer();

            Console.WriteLine("What year were you born in?");
            var year = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your birth day is: {0}", day);
            Console.WriteLine("Your birth year is: {0}", year);

            if (month == "january" && Int32.Parse(day) >= 22)
            {
                Console.WriteLine("you are an Aquarius.");
            }
            else if (month == "january" && Int32.Parse(day) <= 21)
            {
                Console.WriteLine("you are a Capricorn");
            }
            if (month == "february" && Int32.Parse(day) >= 19)
            {
                Console.WriteLine("you are an Pisces.");
            }
            else if (month == "february" && Int32.Parse(day) <= 18)
            {
                Console.WriteLine("you are an Aquarius");
            }
            if (month == "march" && Int32.Parse(day) >= 20)
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "march" && Int32.Parse(day) <= 19)
            {
                Console.WriteLine("you are a Pisces");
            }
            if (month == "april" && Int32.Parse(day) >= 20)
            {
                Console.WriteLine("you are a Taurus");
            }
            else if (month == "april" && Int32.Parse(day) <= 19)
            {
                Console.WriteLine("you are an Aries");
            }
            if (month == "may" && Int32.Parse(day) >= 22)
            {
                Console.WriteLine("you are a Gemini");
            }
            else if (month == "may" && Int32.Parse(day) <= 21)
            {
                Console.WriteLine("you are a Taurus");
            }
            if (month == "june" && Int32.Parse(day) >= 21)
            {
                Console.WriteLine("you are a Cancer.");
            }
            else if (month == "june" && Int32.Parse(day) <= 20)
            {
                Console.WriteLine("you are a Gemini");
            }
            if (month == "july" && Int32.Parse(day) >= 22)
            {
                Console.WriteLine("you are a Leo.");
            }
            else if (month == "july" && Int32.Parse(day) <= 21)
            {
                Console.WriteLine("you are a Cancer");
            }
            if (month == "august" && Int32.Parse(day) >= 23)
            {
                Console.WriteLine("you are an Virgo.");
            }
            else if (month == "august" && Int32.Parse(day) <= 22)
            {
                Console.WriteLine("you are a Leo");
            }
            if (month == "september" && Int32.Parse(day) >= 22)
            {
                Console.WriteLine("you are a Libra.");
            }
            else if (month == "september" && Int32.Parse(day) <= 21)
            {
                Console.WriteLine("you are a Virgo");
            }
            if (month == "october" && Int32.Parse(day) >= 23)
            {
                Console.WriteLine("you are an Scorpio.");
            }
            else if (month == "october" && Int32.Parse(day) <= 22)
            {
                Console.WriteLine("you are a Libra");
            }
            if (month == "november" && Int32.Parse(day) >= 23)
            {
                Console.WriteLine("you are an Sagittarius.");
            }
            else if (month == "november" && Int32.Parse(day) <= 22)
            {
                Console.WriteLine("you are a Scorpio");
            }
            if (month == "december" && Int32.Parse(day) >= 21)
            {
                Console.WriteLine("you are an Capricorn.");
            }
            else if (month == "december" && Int32.Parse(day) <= 20)
            {
                Console.WriteLine("you are a Sagittarius");
            }

            // Determine Chinese Year

            var tiger = Int32.Parse(year) - 1938;
            var rabbit = Int32.Parse(year) - 1939;
            var dragon = Int32.Parse(year) - 1940;
            var snake = Int32.Parse(year) - 1941;
            var horse = Int32.Parse(year) - 1942;
            var goat = Int32.Parse(year) - 1943;
            var monkey = Int32.Parse(year) - 1944;
            var rooster = Int32.Parse(year) - 1945;
            var dog = Int32.Parse(year) - 1946;
            var boar = Int32.Parse(year) - 1947;
            var rat = Int32.Parse(year) - 1948;
            var ox = Int32.Parse(year) - 1949;
            
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

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't write anything, please try again");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}

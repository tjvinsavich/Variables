using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Larry";
            int age = 1000;
            char favLetter = 'Z';
            bool isAlien = true;
            double bodyTemp = 58.6;
            decimal money = 20.68m;

            Console.WriteLine($"His name is {name}. He is " +
                $"{age} years old. His favorite letter of the " +
                $"alphabet is {favLetter}. Is Larry an alien? " +
                $"It is {isAlien}. His current body temperature is " +
                $"{bodyTemp} degress Fahrenheit. He has ${money} in " +
                $"his wallet.");
        }
    }
}

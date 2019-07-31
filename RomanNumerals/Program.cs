using System;
using RomanNumerals.Logic;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanNumeralsLogic = new RomanNumeralsLogic();

            Console.Write("Write here a number between 1 and 3000: ");

            var input = Console.ReadLine();
            int inputInt = Int32.Parse(input);
            var result = romanNumeralsLogic.Get(inputInt);

           
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}

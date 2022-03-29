using System;

namespace GreadingSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            // prilozenie prosit polzovatelja vvesi rezultat ego ekzsmena
            // rezultat ekzamena eto odna bukva ot A do F
            // A - Outstanding
            // B - Superior
            // C - Good
            // D - Satisfactory
            // E - Low Pass
            // F - Failure
            // v rabote prilozenija ispolzuetsa switch()

            Console.WriteLine("Enter your exam result");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userInput)
            {
                case 'A':
                    Console.WriteLine("Outstanding");
                    break;

            }
            switch (userInput)
            {
                case 'B':
                    Console.WriteLine("Superior");
                    break;

            }
            switch (userInput)
            {
                case 'C':
                    Console.WriteLine("Good");
                    break;

            }
            switch (userInput)
            {
                case 'D':
                    Console.WriteLine("Satisfaktory");
                    break;
            }
            switch (userInput)
            {
                case 'E':
                    Console.WriteLine("Low Pass");
                    break;
            }
            switch (userInput)
            {
                case 'F':
                    Console.WriteLine("Failure");
                    break;
            }
        }
    }
}

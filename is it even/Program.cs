using System;

namespace is_it_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it an even number?");

            //prompt user for a number, convert number to integer and assign a variable name
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //print true or false to console from method
            Console.WriteLine(IsEven(number));
            
            Console.ReadLine();
        }
        
        /// <summary>
        /// take user entered number and check to see if even or odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if number is even, false if it is odd</returns>
        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }   

    }
}

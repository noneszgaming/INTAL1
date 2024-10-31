using System;
using System.Globalization;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string:");

            string inputMyString = Console.ReadLine();

            //Console.WriteLine("Username is: " + userName);

            //Console.WriteLine(inputMyString);
            Console.WriteLine();


            inputMyString = String.Concat(
                inputMyString
                .OrderBy(c => char.ToUpper(c))
                .ThenBy(c => c)
            );

            //string sortedStr = inputMyString.OrderBy(myChar => myChar).ToString();

            Console.WriteLine(inputMyString);


        }
    }
}
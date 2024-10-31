using System;
using System.Text;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
            Console.WriteLine("Enter string character:");

            string inputCharacter = Console.ReadLine();

            //
            //string s = "9quali52ty3";
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(inputCharacter);
            foreach (byte b in ASCIIValues)
            {
                Console.WriteLine(b);
            }

            //Console.WriteLine("inputCharacter is: " + inputCharacter);

            */


            // 1. feladat megoldása

            Console.WriteLine("Enter a string character:");

            string inputString = Console.ReadLine();

            Console.WriteLine("Enter a char to search for:");

            string inputCharacterRaw = Console.ReadLine();

            char inputCharacter = char.Parse(inputCharacterRaw);


            //Console.WriteLine(inputString);

            //Console.WriteLine(inputCharacter);


            if (inputString.Contains(inputCharacter))
            {
                Console.WriteLine(inputString);

                int searchResult = inputString.IndexOf(inputCharacter);

                Console.WriteLine(searchResult + ". index");

            }
            else
            {
                Console.WriteLine("Not Found.");

            }


        }
    }
}


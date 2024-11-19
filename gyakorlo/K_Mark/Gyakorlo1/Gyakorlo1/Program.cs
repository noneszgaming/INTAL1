//  Demo Feladat:	
//
//      Input username adat eltárol változóba, 
//	    ezután txt -be kiírattat.

using System;

namespace Gyakorlo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter username: ");

            string userName = Console.ReadLine();

            //Console.WriteLine("Username is: " + "'" + userName + "'");


            // writing into a txt file 
            var outputPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\outputText.txt"));


            var outputText = File.ReadAllText(outputPath);

            var outputLines = File.ReadAllLines(outputPath);


            using (StreamWriter outputFile = new StreamWriter(outputPath, append: true)) 
            {

                outputFile.WriteLine(userName);
            
            }

            Console.WriteLine("\nWrite to file finished.");

        }


    }


}
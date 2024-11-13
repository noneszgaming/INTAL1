// Feladat 1
// 3. Lineáris keresés (rendezetlen és rendezett esetben)
//
//
// RENDEZETLEN eset
//
//


using System;
using System.Text;

namespace Feladat1_F03
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] nums = { 121231, 52, 8565, 422 };

            int searchedNumber = 8565;        //searchedNumber = 52;

            int iteratedIndex = 0;

            foreach (int iter in nums)
            {

                //Console.WriteLine(iter);

                //Console.WriteLine(iter);

                if (iter == searchedNumber)
                {
                    //Console.WriteLine("Az elem helye:", iter, "maga az elem:", iter);

                    Console.WriteLine("az elem: " + iter);
                    Console.WriteLine("index: " + iteratedIndex);

                }
                else
                {

                    iteratedIndex++;

                    //Console.WriteLine("Nincs ilyen elem.");


                }

            }

        }
    }

}

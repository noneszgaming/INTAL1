// Feladat 2
//  
// 4.Hash tábla kezelése. Input: hash méret, értékek. Output: hash tábla
//
//


using System;
using System.Collections;

class Feladat2_F04
{

    static public void Main()
    {

        Hashtable my_hashtable1 = new Hashtable();

        my_hashtable1.Add("ID1", 20241010);
        my_hashtable1.Add("ID2", 20241101);
        my_hashtable1.Add("ID3", 20241114);

        Console.WriteLine("Key and Value pairs from my_hashtable1:");


        foreach (DictionaryEntry ele1 in my_hashtable1)
        {
            //Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);

            Console.WriteLine(ele1.Key + "," + ele1.Value);

            //Console.WriteLine();

        }

        Console.WriteLine();


        /*
        Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};

        Console.WriteLine("Key and Value pairs from my_hashtable2:");

        foreach (var ele2 in my_hashtable2.Keys)
        {
            Console.WriteLine("{0}and {1}", ele2,
                            my_hashtable2[ele2]);
        }

        */


    }

}

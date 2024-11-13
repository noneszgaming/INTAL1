// Feladat 3
//
// 5. Láncolt lista. 'CRUD'
//
// Linked List : create , read , update , delete
//
//


using System;
using System.Collections.Generic;

class Feladat3_F05
{

    static public void Main()
    {

        LinkedList<String> my_list = new LinkedList<String>();


        // create
        my_list.AddLast("Adam");
        my_list.AddLast("Bela");
        my_list.AddLast("Cecil");
        my_list.AddLast("Dominika");


        Console.WriteLine("Best students of XYZ university:");


        // read
        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }


        Console.WriteLine();
        // update
        my_list.Find("Dominika").Value = "Domi";

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }


        Console.WriteLine();
        // delete
        my_list.Remove("Cecil");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

    }


}

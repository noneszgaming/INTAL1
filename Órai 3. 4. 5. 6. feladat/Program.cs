using System;
using System.Collections.Generic;
using System.Linq;

int index = -1;

int i = 0;
int n = 0;
int[] x = new int[2];
//bool T = false;


//Ciklus, amíg  van még vizsgálható elem a tömbben 

//NEM IGAZ, hogy az aktuális vizsgált elem T tulajdonságú. 

//Ha mind a két feltétel teljesül, akkor nézzük meg a következő elemet. 

 
while ((i < n) && !(T(x[i])))

{

    i++;

}



var van = (i < n);

if (van)

{
    Console.WriteLine("Van: " + i);
    index = i;

}
bool T(int v)
{
    throw new NotImplementedException();
}
//Ha egy változó nem kap értéket,

//akkor az c#-ban okozhat gondot. 

//Ezért a legelején -1 étéket adunk! 

//Egy tömbnek a -1, mint index értelmetlen 

//Ezt az értéken nem használhatjuk fel! 


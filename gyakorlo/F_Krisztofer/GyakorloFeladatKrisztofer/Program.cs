//Demo feladat
//"Username beolvasások input txt fájlból majd pedig kiirattat"

using System;
using System.IO;

class Program
{
    static void Main()
    {
        //txt file elérési útvonala.
        //A Directory.GetCurrentDirectory() metódus tartalmazza az aktuális munkakönyvtár elérési útját (Ez egy abszolút út).
        //A @"..\..\..\userNevek.txt a realtív elérési útja a txt file-nak.
        //3 szintel feljebb lépünk (..\..\..), hogy elérjük a txt file mappáját, ami ebben az esetben a project mappája.
        //Path.GetFullPath() üsszefűzi a Path.Combine() segítségével az elérési utat egy stringé.
        string txtFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\userNevek.txt"));

        //A txt file minden egyes sora külön-külön eltárolásra kerül egy tömbben.
        string[] txtFileTartalma = File.ReadAllLines(txtFilePath);

        //a string tömb kiíratása console-ra.
        foreach (string txtFileSora in txtFileTartalma)
        {
            Console.WriteLine(txtFileSora);
        }
    }
}
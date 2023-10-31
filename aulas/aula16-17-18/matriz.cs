using System;

class matriz
{
    static void Main()
    {
        int conta=0;
        int [,] n=new int[2,2];
        n[0,0]=6;
        n[0,1]=13;
        n[1,0]=24;
        n[1,1]=15;

        conta=n[0,1]+n[0,0];

        Console.WriteLine("\n"+conta);
    }
}
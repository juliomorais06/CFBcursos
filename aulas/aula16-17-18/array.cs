using System;

class array
{
    static void Main()
    {
        int[] array=new int[5];
        array[0]=10;
        array[1]=20;
        array[2]=30;
        array[3]=40;
        array[4]=50;

        Console.WriteLine(array[0]+array[4]+"\n");

        string[] palavras=new string[2] {"Julio","Angélica"};

        Console.WriteLine(palavras[0]+" e "+palavras[1]);

        int[] array2={1,2,3,4,5,6};
        Console.Write(array2[1]+array[2]);
    }
}
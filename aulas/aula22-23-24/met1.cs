using System;

class metodosarray
{
    static void Main()
    {
        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[,] matriz=new int[2,5]{{10,20,30,40,50},{15,25,35,45,55}};

        Random random=new Random();
        for(int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);
        }
    Console.WriteLine("Elementos vetor1");
    foreach(int n in vetor1){
        Console.WriteLine(n);
    }
    }
}
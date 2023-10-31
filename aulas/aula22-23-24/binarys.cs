using System;

class binarysearch{
    static void Main(){
        int[] vetor1=new int[5];
        int[] vetor2=new int[]{5,4,7,13,44,21};
        int[] vetor3=new int[5];

        /*Random random=new Random();
        for(int i=0;i<vetor2.Length;i++){
            vetor2[i]=random.Next(5);
        }*/
        int procurado=13;
        int posicao=Array.BinarySearch(vetor2,procurado);
        Console.WriteLine("o valor {0} esta na posição {1}",procurado,posicao);
        Console.Write("--------------------------------");
    }
}
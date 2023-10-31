using System;

class treino{
    static void Main(){
        int[] vetor=new int[30];
        Random prim=new Random();
        for(int i=0;i<vetor.Length;i++){
            vetor[i]=prim.Next(10);
        }
        Console.WriteLine("numeros:");
        foreach(int v in vetor){
            Console.WriteLine(v);
        }
    }
}
using System;

class copy{
    static void Main(){
        int[] vetor1=new int[5];
        int[] vetor2=new int[]{5,4,7,13,44,21};
        int[] vetor3=new int[6];

        /*Random random=new Random();
        for(int i=0;i<vetor2.Length;i++){
            vetor2[i]=random.Next(5);
        }*/
        Array.Copy(vetor2,vetor3,vetor2.Length);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.Write("--------------------------------");
    }
}
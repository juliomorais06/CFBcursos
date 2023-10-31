using System;

class copy{
    static void Main(){
        int[] vetor1=new int[]{4,5,7,6,3,2};
        int[] vetor2=new int[8];
        int[] vetor3=new int[5];

        /*Random random=new Random();
        for(int i=0;i<vetor2.Length;i++){
            vetor2[i]=random.Next(5);
        }*/
        vetor1.CopyTo(vetor2,2);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        }
    }
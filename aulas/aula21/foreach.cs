using System;

class comandoforeach
{
    static void Main()
    {
        //recomendado para leitura e iteração dos elementos
        //exemple for abaixo
        /*
        int[] num=new int[4]{10,20,30,40};
        for(int i=0;i<num.Length;i++){
            Console.WriteLine(num[i]);
            */
        int[] num=new int[4]{10,20,30,40};
        foreach(int n in num){
            Console.WriteLine(n);
        }

    }
}
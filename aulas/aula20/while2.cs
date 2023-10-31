using System;

class while2
{
    static void Main()
    {
        int[] sec=new int[11];
        int i=0;

        while(i<10){
            sec[i]=1;
            i++;

            Console.WriteLine("Posição {0} - valor {1}.",i,sec[0]++);
        }
    }
    //while testa a condição e executa
        //pode ser que nenhuma condição seja testada 
    //do while exucuta as condições e testa somente no final
        //garante que ao menos uma condição seja testada
}
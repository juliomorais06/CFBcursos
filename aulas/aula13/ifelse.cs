using System;

class ifelse
{
    static void Main()
    {
        int n1,n2,n3,n4,res;
        n1=n2=n3=n4=res=0;
        string resultado="Aprovado";

        Console.WriteLine("Escreva sua primeira nota: \n");
        n1=int.Parse(Console.ReadLine());

         Console.WriteLine("Escreva sua segunda nota: \n");
        n2=int.Parse(Console.ReadLine());

         Console.WriteLine("Escreva sua terceira nota: \n");
        n3=int.Parse(Console.ReadLine());

         Console.WriteLine("Escreva sua quarta nota: \n");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        if(res>=70)
        {
            Console.WriteLine("{1}, sua nota foi {0}.", res, resultado);
        }else if(res>=40){
            Console.WriteLine("Recuperação, terá mais uma chance.");
        }else{
            Console.WriteLine("Você foi reprovado nota {0}", res);
        }
    }
}
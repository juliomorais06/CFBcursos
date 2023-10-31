using System;

class ifaninhado
{
    static void Main()
    {
        int n1,n2,n3,n4,res;
        n1=n2=n3=n4=res=0;
        string resultado="Aprovado";
        string result2="Aprovado com louvor";
        string result3="Super aprovado, nota máxima";
        string recup="Está de recuperação";
        string repro="Reprovado";

        Console.WriteLine("Escreva sua primeira nota: \n");
        n1=int.Parse(Console.ReadLine());

         Console.WriteLine("Escreva sua segunda nota: \n");
        n2=int.Parse(Console.ReadLine());

         Console.WriteLine("Escreva sua terceira nota: \n");
        n3=int.Parse(Console.ReadLine());

         Console.WriteLine("Escreva sua quarta nota: \n");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        if(res<60){
            if(res>=40){
                Console.WriteLine("Nota {0}, {1}", res, recup);
            }else{
                Console.WriteLine("Nota {0}, {1}", res, repro);
            }
        }else{
            if(res<90){
                Console.WriteLine("{0}", resultado);
            }else if(res<100){
                Console.WriteLine("Nota {0}, {1}", res, result2);
            }else{
                Console.WriteLine("{0}", result3);
            }
        }
    }   
}
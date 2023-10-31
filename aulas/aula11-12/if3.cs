using System;

class if3
{
    static void Main()
    {
        int n1,n2,n3,n4,somanotas;
        somanotas=n1=n2=n3=n4=0;
        string resultado="Reprovado";

        Console.WriteLine("Escreva a primeira nota: ");
        n1=int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a segunda nota: ");
        n2=int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a terceira nota: ");
        n3=int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a quarta nota: ");
        n4=int.Parse(Console.ReadLine());

        somanotas=n1+n2+n3+n4;

        if(somanotas>=60)
        {
            resultado="Aprovado";
        }

        Console.WriteLine(resultado);
    }
}
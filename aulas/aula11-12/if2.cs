using System;

class if2
{
    static void Main()
    {
        int nota=0;
        string resultado="Reprovado";
        nota=int.Parse(Console.ReadLine());

        if(nota>=60)
        {
            resultado="Aprovado";
        }
    Console.WriteLine(resultado);
    }
}
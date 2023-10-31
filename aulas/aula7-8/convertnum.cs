using System;

class convertnum
{
    static void Main()
    {
        int n1, n2, soma;

        Console.Write("Digite um número: ");
        n1=int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        n2=int.Parse(Console.ReadLine());
        soma=n1 + n2;

        Console.Write("A soma entre {0} e {1} é igual a {2}.", n1, n2, soma);
    }
}
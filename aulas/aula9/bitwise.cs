using System;

class aula09
{
    // bitwise << dobra o valor da variável
    // bitwise >> divide pela metade o valor da variável
    //também chamados de operadores de shift
    static void Main()
    {
        int num=10;
        num=num<<3;

        Console.WriteLine(num);

        int num2=30;
        num2=num2>>2;
        Console.WriteLine(num2);
    }
}
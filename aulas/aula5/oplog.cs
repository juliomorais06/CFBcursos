using System;
class operadoreslogicos
{
    static void Main()
    {
        // & = AND / E = retorna true somente se as duas forem verdadeiras
        // | = OR / OU = retorna true se uma das afirmações for verdadeira

        bool res = (5<7) | (10<5);
        Console.WriteLine(res);

        bool resII = (5<2) & (10>5);
        Console.WriteLine(resII);
    }
}
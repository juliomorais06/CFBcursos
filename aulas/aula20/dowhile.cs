using System;

class dowhile
{
    static void Main()
    {
        string senha="1234";
        string senhauser;
        int tentativas=0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser=Console.ReadLine();
            tentativas++;
        }while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha correta, {0} tentativas", tentativas);
    }
}
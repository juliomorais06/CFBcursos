using System;

class exemplo
{
    static void Main()
    {
        int num=0;
        char tipo;
        inicio:

        Console.WriteLine("com qual veículo quer viajar? (a)avião|(b)carro|(c)ônibus \n");
        tipo=char.Parse(Console.ReadLine());

        switch(tipo){
            case 'a':
            case 'A':
                num=30;
                Console.WriteLine("Tempo de viajem: {0} minutos", num);
                break;

            case 'b':
            case 'B':
                num=180;
                Console.WriteLine("Tempo de viajem: {0} minutos", num);
                break;

            case 'c':
            case 'C':
                num=300;
                Console.WriteLine("Tempo de viajem: {0} minutos", num);
                break;

            default:
                Console.WriteLine("Entrada incorreta, tente novamente..");
                Console.Clear();
                goto inicio;
        }
    }
}
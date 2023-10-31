using System;

class switchcase
{
    static void Main()
    {
        int tempo=0;
        char escolha;
        label:

        Console.WriteLine("Viajem de Londrina a Curitiba");
        Console.WriteLine("\nEscolha o meio de transporte: (a)Avião | (c)Carro | (o)Ônibus");
        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;

            case 'c':
            case 'C':
                tempo=480;
                break;

            case 'o':
            case 'O':
                tempo=660;
                break;
            
            default:
                tempo=-1;
                break;
        }
        
        if(tempo<0){
            Console.WriteLine("Transporte inexistente");
            Console.Clear();
            goto label;
        }
        else{
            Console.WriteLine("O tempo da viajem é {0} minutos para o transporte escolhido", tempo);
        }
        
    }
}
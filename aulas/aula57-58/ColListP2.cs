using System;
using System.Collections.Generic;

class ColListP2{
    static void Main(){
        List<string> veiculos = new List<string>();

        veiculos.Add("Gol");
        veiculos.Add("Celta");
        veiculos.Add("Biz");
        veiculos.Add("Titan");
        veiculos.Add("Celta");

        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        }
        
        Console.WriteLine("\n---------------------------------------\n");
        
        veiculos.Insert(1, "Cruze"); //.Insert(chave,valor), insere um valor na posição indicada

        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        }

        string car = "Celta";
        int posicao = 0;
        posicao = veiculos.LastIndexOf(car); // .LastIndexOf, neste método retorna o último item encontrado se tiver 2 ou mais iguais
        Console.WriteLine("O último {0} está na posição {1}", car, posicao);

        Console.WriteLine("\n---------------------------------------\n");
        
        veiculos.Remove("Titan");

        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        }

        Console.WriteLine("\n---------------------------------------\n");

        veiculos.RemoveAt(0); //.RemoveAt remove o item da posição indicada

        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        }    

        Console.WriteLine("\n---------------------------------------\n");

        veiculos.Reverse(); // .Reverse() reverte a ordem da lista   

        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        } 

        Console.WriteLine("\n---------------------------------------\n");

        veiculos.Sort(); //.Sort ordena a lista em ordem alfabética

        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        }

        Console.WriteLine("\n---------------------------------------\n");

        int tamanho = veiculos.Count; // .Count retorna um inteiro, tamanho da lista
        Console.WriteLine("Tamanho da lista: {0}", tamanho);

        veiculos.Capacity = 15; // define o tamanho que se quer para a lista
        int capacidate = veiculos.Capacity; //.Capacity recorna a capacidade da lista
        Console.WriteLine("Capacidade da lista: {0}", capacidate);
    }
}
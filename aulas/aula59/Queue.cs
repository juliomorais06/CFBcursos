using System;
using System.Collections.Generic;

//primeiro a entrar é o primeiro a sair
//último a entra é o último a sair
//sempre é manipulado o elemento que está na vez, em ordem

class Queue{
    static void Main(){
        //string[] vs = {"Carro","moto","Navio","Avião"};
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); //.Enqueue adiciona elementos ao final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");  

        string v = "Patinete";
        if(veiculos.Contains(v)){ //pesquisa se existe o elemento na fila
            Console.WriteLine("Veículo "+ v + " encontrado.");
        }else {
            Console.WriteLine("Veículo "+ v + " não está na fila");
        }
        
        //veiculos.Clear(); //.Clear() limpa a fila
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count); 

        Console.WriteLine("Primeiro veículo "+ veiculos.Dequeue()); //.Dequeue() retorna o primeiro veículo e o remove da fila

        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count); 

        Console.WriteLine("Primeiro veículo "+ veiculos.Dequeue());

        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count); 

        Console.WriteLine("Primeiro veículo "+ veiculos.Peek()); //.Peek() retorna o primeiro elemento e não o remove

        Console.WriteLine("Tamanho da fila: {0}\n", veiculos.Count);

        foreach(string veic in veiculos){
            Console.WriteLine("Veiculos: "+veic);
        }
        
        while(veiculos.Count > 0){ //while pode ser utilizado quando não se sabe o tamanho da fila
            Console.WriteLine("Veículos: "+ veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho da fila: {0}\n", veiculos.Count);
    }
}
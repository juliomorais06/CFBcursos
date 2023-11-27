using System;
using System.Collections.Generic;

class Aula56{ //lista duplamente encadeada, cada elemento é um nó da lista, tem link anterior e posterior
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");  //AddFirst sempre adiciona o elemento no início
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Nave"); //AddLast adiciona o elemento no final da lista
        
        LinkedListNode<string> no; // para criar o nó(node)
        no = transp.FindLast("Navio").Next; //para não dar erro na adição, .Next aponta para o elemento posterior ao indicado
        transp.AddAfter(no, "Patinete"); //adiciona elemento depois

        LinkedListNode<string> node;
        node = transp.FindLast("Nave"); //.Value retorna o próprio valor do nó
        transp.AddBefore(node, "Skate"); // adiciona elemento antes

        //transp.Clear(); // limpa a lista

        if(transp.Find("Avião") == null){ // busca um elemento e retorna a referência para o elemento, se não tiver retorna null
            Console.WriteLine("Não encontrado");
        }else {
            Console.WriteLine("Elemento encontrado");
        }

        transp.Remove("Motocicleta"); //remove um elemento da lista  
        transp.RemoveFirst(); //remove o primeiro
        transp.RemoveLast(); //remove o último

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}", t);
            }
        }
}
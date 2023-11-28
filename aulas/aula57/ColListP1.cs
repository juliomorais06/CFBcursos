using System;
using System.Collections.Generic;

class ColListP1{ // coleção List é usada toda vez que se quer substituir o Array tradidicional
                 //pode ser considerado um Array dinâmico
    static void Main(){
        List<string> carros = new List<string>();
        string[] carros2 = new string[6];

        carros.Add("Golf"); //.Add adicona na mesma sequência
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros.Clear(); //.Clear deleta os elementos de uma lista

        if(carros.Contains("Gol")){ //.Contains verifica se um item está na lista, retorna true ou false
            Console.WriteLine("Está na lista");
        }else {
            Console.WriteLine("O item não está na lista");
        }
        
        //carros2.AddRange(carros); //.AddRange adiciona todos os elementos de uma lista em nova lista

        foreach(string c in carros){
            Console.WriteLine("Carro: {0}.", c);
        }

        //carros2.Clear(); //.Clear deleta os elementos de uma lista

        carros.CopyTo(carros2,1); //copia a partir de uma posição de uma lista para um novo array (tem que ser array tradicional)

        foreach(string c2 in carros2){
            Console.WriteLine("Carros2: {0}", c2);
        }

        string car = "Argo";
        int posicao = 0;
        posicao = carros.IndexOf(car); //.IndexOf pesquisa se o item está na lsita e neste caso retora a posição
        Console.WriteLine("O carro {0} está na posição {1}", car, posicao);
    }
}
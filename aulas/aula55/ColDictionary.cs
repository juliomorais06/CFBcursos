using System;
using System.Collections.Generic;

//é uma coleção de dados relacionado por chave e valor

class ColDictionary{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary<int, string>();//chave, valor: pode ser de tipos diferentes.

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");
        
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        veiculos.Clear();

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        int chave = 20;
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} está na coleção Dictionary", chave);
        }else {
            Console.WriteLine("A chave {0} não está na coleção Dictionary", chave);
        }
        
        veiculos.Remove(20); //.Remove: remove chave e valor

        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} está na coleção Dictionary", chave);
        }else {
            Console.WriteLine("A chave {0} não está na coleção Dictionary", chave);
        }

        veiculos[15] = "Bicicleta"; //muda o valor 

        string valor = "Bicicleta";
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("A chave {0} está na coleção Dictionary", valor);
        }else {
            Console.WriteLine("A chave {0} não está na coleção Dictionary", valor);
        }

        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Value);
        }
        
        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Key);
    }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values; //para não precisar passar keyvaluepair no foreach
        foreach(string v in valores){
            Console.WriteLine(v);
    }
}
}
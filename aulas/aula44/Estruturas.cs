using System;

//Struct - estrutura é um tipo que permite o armazenamento de diferentes tipos de dados
//os elementos são acessados diretamente
//como não é CLASSE, não pode herdar nem servir como base para herança
//pode ter construtor

struct CarrO{
    public string marca;
    public string modelo;
    public string cor;
    public CarrO(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info(){
        Console.WriteLine("Marca: {0} | Modelo: {1} | Cor: {2}", this.marca, this.modelo, this.cor);
    }
}

class Estrutura{
    static void Main(){
        CarrO c10; //sem utilizar o construtor
        c10.marca = "VW";
        c10.modelo = "GOLF";
        c10.cor = "BRANCO";
        c10.info();

    }
}
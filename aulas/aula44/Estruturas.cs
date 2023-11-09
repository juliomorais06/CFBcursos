using System;

//Struct - estrutura é um tipo que permite o armazenamento de diferentes tipos de dados
//os elementos são acessados diretamente
//como não é CLASSE, não pode herdar nem servir como base para herança
//pode ter construtor

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor){
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
        Carro c1; //sem utilizar o construtor
        c1.marca = "VW";
        c1.modelo = "GOLF";
        c1.cor = "BRANCO";
        c1.info();

        Carro c2 = new Carro("HONDA", "CIVIC", "PRETO"); //utilizando o construtor
        c2.info();
    }
}
using System;

//interfaces só implemantam os métodos ou os protótipos dos métodos;
//só utiliza as assinaturas dos métodos;
//uma classe pode herdar mais de uma interface;
//interface não pode ter construtor nem destrutor. Não pode ter método operator;
//não pode definir membros static;

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}
public interface Combate{
    void disparar();
}
class Carro:Veiculo, Combate{  //implementação das interfaces
    public bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde;
    }
    public void ligar(){
        this.ligado = true;
    }
    public bool getLigado(){
        return ligado;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void disparar(){}
    public void info(){}
}

class Interfaces{
    static void Main(){
        Carro c1 = new Carro();
        c1.ligar();
        Console.WriteLine(c1.getLigado());
        c1.desligar();
        Console.WriteLine(c1.getLigado());
    }
}
using System;

//aula classes e métodos abstratos
abstract class Veiculo{//classe base abstrata
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);//necessário implementar pois não é um método abstrato
}

class Carro:Veiculo{
    public Carro(){
        velMaxima = 120;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}

class MetodosAbstratos{
    static void Main(){
        Carro carro1 = new Carro();
        Console.WriteLine(carro1.getVelAtual());
        carro1.aceleracao(5);
        Console.WriteLine(carro1.getVelAtual()); 
        carro1.aceleracao(-2);
        Console.WriteLine(carro1.getVelAtual());      
    }
}
using System;
//new para criar objetos na classe
public class Jogador{

    public int energia=100;

    public bool vivo=true;

}
class aula28{
    static void Main(){
        Jogador j1=new Jogador();
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();

        j1.energia=50;
        Console.WriteLine("Energia do jogador 1: {0}",j1.energia);
        Console.WriteLine("Energia do jogador 1: {0}",j2.energia);
    }
}
//3 objetos na da classe jogador, cada um alocado em uma posição diferente de memória
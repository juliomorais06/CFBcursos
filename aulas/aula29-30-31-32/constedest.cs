using System;
//new para criar objetos na classe
//o método construtor precisar ter o mesmo nome da classe
public class Jogador{

    public int energia;

    public bool vivo;
    public string nome;//tem escopo global à classe
    public Jogador(string n){ //esse é o cronstrutor
        energia=100;             //tem escopo local ao método
        vivo=true;
        nome=n;
    }
    ~Jogador(){
        Console.WriteLine("jogador foi deletado");
    }
//método construtor é o método que será executado quando se instanciar um objeto p/ classe
//destrutor vai ser executado quando a classe for destruída
//é o nome da classe precedido de um ~
}
class aula28{
    static void Main(){
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Angélica");
       
        Console.WriteLine("Nome do jogador 1: {0}",j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}",j2.nome);
    }
}
using System;
//new para criar objetos na classe
//o método construtor precisar ter o mesmo nome da classe
public class Jogador{

    public int energia;

    public bool vivo;
    public string nome;//tem escopo global à classe
    public Jogador(){ //esse é o cronstrutor
        energia=100;             //tem escopo local ao método
        vivo=true;
        nome="Jogador";
    }
    public Jogador(string n){ 
        energia=100;             
        vivo=true;
        nome=n;
    }
      public Jogador(string n, int e){ 
        energia=e;             
        vivo=true;
        nome=n;
    }
     public Jogador(string n, int e, bool v){ 
        energia=e;             
        vivo=v;
        nome=n;
    }
    public void info(){
        Console.WriteLine("Nome jogador:... {0}",nome);
        Console.WriteLine("Energia jogador: {0}",energia);
        Console.WriteLine("Estado jogador:. {0}\n",vivo);
    }
   
//método construtor é o método que será executado quando se instanciar um objeto p/ classe
//destrutor vai ser executado quando a classe for destruída
//é o nome da classe precedido de um ~
}
class aula28{
    static void Main(){

        Jogador j1=new Jogador();
        Jogador j2=new Jogador("Julio");
        Jogador j3=new Jogador("Angélica",100);
        Jogador j4=new Jogador("Morais",0,false);
       
        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}
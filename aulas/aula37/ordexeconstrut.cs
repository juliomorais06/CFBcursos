using System;
//ordem de execução dos construtores vai da base para as derivadas;
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
}
class ordexeconstrut{
    static void Main(){
        Derivada2 derivada2 = new Derivada2();
    }
} 
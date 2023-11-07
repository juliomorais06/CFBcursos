using System;

//são métodos que tem o mesmo nome da classe base, porém tem ações diferentes
//virtual public void.., override public void..
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info(){
        Console.WriteLine("Base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
    override public void info(){
        Console.WriteLine("Derivada 1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}
class MetodosVirtuais{
    static void Main(){
        Base Ref; //para referênciar para outra classe utiliza-se Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        
        Ref = derivada1;
        Ref.info();
        derivada2.info();
    }
}
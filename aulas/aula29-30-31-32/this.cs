//operador this
using System;

class Calculos{

    public int v1;

    public int v2;

    public Calculos(int v1, int v2){
        this.v1=v1;
        this.v2=v2;
    }

    public int somar(){
        return v1+v2;
    }
}

class This{

    static void Main(){
        Calculos c=new Calculos(10,2);
        Console.WriteLine(c.somar());
    }
}
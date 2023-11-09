using System;

//Acessor - é uma propriedade/método que pode atribuir valor, obter o valor e processar um dado.
class Carro{
    private int velMax;

    public int vm{
        get{
            return velMax;
        }
        set{
            if(value < 0){
                velMax = 0;
            } else if(value > 300){
                velMax = 300;
            }else{
                velMax = value;
            }
        }
    }
    public Carro(){
        vm = 120;
    }

}

class AcessorsGetSet{
    static void Main(){
        Carro c1 = new Carro();
        c1.vm = 200;
        Console.WriteLine("Velocidade: {0}", c1.vm);
    }
}
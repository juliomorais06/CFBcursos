using System;

//indexador - é um membro de uma classe que permite que elementos sejam indexados como se fossem arrays
    class Carro{
    private int[] velMax = new int[5]{80,120,160,240,300};

    public int this[int i]{ //esse é o indexador
        get{
            return velMax[i];
        }
        set{
            if(value < 0){
                velMax[i] = 0;
            } else if(value > 300){
                velMax[i] = 300;
            }else{
                velMax[i] = value;
            }
        }
    }
    public Carro(){
    }

}

class AcessorsGetSet{
    static void Main(){
        Carro c1 = new Carro();
        c1[4] = 200;
        Console.WriteLine("Velocidade: {0}", c1[4]);
    }
}
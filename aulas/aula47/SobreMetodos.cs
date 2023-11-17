using System;

class Calc{
    public int soma(params int[]n){
        int s = 0;
        for(int i = 0; i < n.Length; i++){
            s += n[i];
        }
        return s;
    }
    public double soma(params double[]n){
        double s = 0;
        for(int i = 0; i < n.Length; i++){
            s += n[i];
        }
        return s;
    }
}

class SobreMetodos{
    static void Main(){
        double res;
        Calc calculadora = new Calc();
        res = calculadora.soma(45, 55);
        Console.WriteLine(res);

        double res2;
        res2 = calculadora.soma(10, 20, 30.45, 5, 87, 4, 3, 2.6, 1.11);
        Console.WriteLine(res2);
    }
}
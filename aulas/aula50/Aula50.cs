using System;

delegate int Op(int n1, int n2);

//Delegates pode fazer referência à um ou mais métodos.
//obtem o endereço de memória do ponto de entrada do método.

class Mat{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }
    public static int mult(int n1, int n2){
        return n1 * n2;
    }
}

class Aula50{
    static void Main(){
        int res = 0;
        
        Op d1 = new Op(Mat.soma);
        
        res = d1(10, 50);
        Console.WriteLine("Soma: {}", res);

        d1 = new Op(Mat.mult);

        res = d1(10, 50);
        Console.WriteLine("Multiplicação: {}", res);
    }
}
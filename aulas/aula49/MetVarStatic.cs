using System;

//Métodos e Variáveis Static: quando declarado como Static, não é necessário instanciar o objeto da classe,
//mas sim, somente chamar diretamente a classe com seu método ou atributo (ex: "Mat.pi ou Mat.dobro())".

class Mat{
    public static double pi = 3.14;
    public static int dobro(int n){
        return n * 2;
    } 
}
class MetVarStatic{ 
    static void Main(){
        double vpi = Mat.pi;
        int num = 10;

        Console.WriteLine(Mat.pi);
        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));
    }
}
using System;

class metodo3 {

    static void Main() {
        Console.WriteLine("digite o primeiro valor");
        int v1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("digite o segundo valor");
        int v2=Convert.ToInt32(Console.ReadLine());
        soma(v1,v2);
    }

    static void soma(int n1, int n2) {
        int res=n1+n2;
        Console.WriteLine("{0} + {1} é {2}",n1,n2,res);
    }
}
using System;

class metodo5 {
    static void Main() {
        int v1,v2;
        v1=Convert.ToInt32(Console.ReadLine());
        v2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} + {1} é {2}",v1,v2,soma(v1,v2));
    }
    static int soma(int n1, int n2) {
        int res=n1+n2;
        return res;
    }
}
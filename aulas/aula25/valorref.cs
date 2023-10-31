using System;

class valorref {
    /*static void Main() {
        int num=10;
        dobrar(num);
        Console.WriteLine(num);

    }
    static void dobrar(int valor) {
        valor*=2;
    }*/
    static void Main() {
        int num=10;
        dobrar(ref num);
        Console.WriteLine(num);

    }
    static void dobrar(ref int valor) {
        valor*=2;
    }
}
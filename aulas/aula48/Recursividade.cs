using System;

class Calc{
    public int fat(int n){
        int res;
        if(n <= 1){
            res = 1;
        }else{
            res = n * fat(n-1);
        }
        return res;
    }
}

class Recursividade{ //uma função chamando ela mesma
    static void Main(){
        Calc calc = new Calc();
        var res = calc.fat(6);
        Console.WriteLine(res);
    }
}
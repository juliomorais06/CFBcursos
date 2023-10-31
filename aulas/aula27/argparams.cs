using System;
//não precisa expor quantos  parâmetros se quer utilizar
class argparams {
    static void Main() {
        soma(6,13);
    }
    static void soma(params int[]n) {
        int res=0;
        if(n.Length<1){
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length<2){
            Console.WriteLine("Valores insuficientes a serem somados");
        }else{
            for(int i=0;i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A soma dos números é {0}",res);
        }
    }
 
 }
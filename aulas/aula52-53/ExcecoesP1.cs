using System;

class ExcecoesP1{
    static void Main(){
        int n1, n2, res;
        n1 = n2 = res = 0;
        n1 = 10;
        n2 = 0;
        
        try{
            res = n1 / n2;   
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res); 
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}", e.Message);
            Console.WriteLine("Ex: {0}", e.GetType());
        }finally{//é executato independentemente se houve ou não a exceção
            Console.WriteLine("Fim do processo");
        }
    }
}
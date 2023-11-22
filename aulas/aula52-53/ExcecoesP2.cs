using System;

class Area{
    public static float Quad(float bas, float alt){
        if(bas <= 0 || alt <= 0){
            throw new Exception("Base ou Altura não podem ser igual ou inferior a zero");
        }
        return bas * alt;
    }
}

class ExcecoesP2{
    static void Main(){
        float area = 0;
        
        try{
            area = Area.Quad(0F, 5F);
            Console.WriteLine("Area do quadrado: {0}", area);
        }catch(Exception e){
           Console.WriteLine("ERRO: {0}", e.Message);
        }finally{ //é executato independentemente se houve ou não a exceção
            Console.WriteLine("Fim do processo");
        }
    }
}
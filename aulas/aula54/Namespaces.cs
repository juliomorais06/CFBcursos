using System;

namespace Calc1{ // organiza os escopos ou as classes, ou seja pode ter classes com o mesmo nome se estiverem em namespaces diferente
    class Area{
    public static float Quad(float bas, float alt){
        if(bas <= 0 || alt <= 0){
            throw new Exception("Base ou Altura não podem ser igual ou inferior a zero");
        }
        return bas * alt;
    }
}
}

namespace Calc2{
    class Area{
    public static int Quad(int bas, int alt){
        if(bas * alt > 1000){
            throw new Exception("Área acima de 1000m");
        }
        return bas * alt;
    }
}
}

class Namespaces{
    static void Main(){
        int area = 0;
        
        try{
            area = Calc2.Area.Quad(23, 5); 
            Console.WriteLine("Area do quadrado: {0}", area);
        }catch(Exception e){
           Console.WriteLine("ERRO: {0}", e.Message);
        }finally{ //é executato independentemente se houve ou não a exceção
            Console.WriteLine("Fim do processo");
        }
    }
}
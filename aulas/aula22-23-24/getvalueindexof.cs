using System;

class metodos {
    static void Main() {
        int[] vetor=new int[]{1,2,3,4,3};
        int[,] matriz=new int[2,5]{{6,7,8,9,10},{11,12,13,14,15}};

        //public object GetValue(long índice), necessário fazer converção(cast) p/ o tipo de objeto que se tem
        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor.GetValue(2));
        int valor1=Convert.ToInt32(matriz.GetValue(0,4));
        Console.WriteLine("vetor na pos 2 tem valor {0}",valor0);
        Console.WriteLine("matriz na pos (0,4) tem valor {0}",valor1);

        //public static int IndexOf(array,valor);
        //retorna o índice do valor que se quer encontrar no array;
        //se tiver mais de um índice com o mesmo valor, retornará o primeiro encontrado;
        Console.WriteLine("IndexOf");
        int valor2=Array.IndexOf(vetor,3);
        Console.WriteLine("o valor indicado vem primeiro na posição {0}",valor2);
        Console.WriteLine("---------------------------------");

         //public static int LastIndexOf(array,valor);
        //retorna o índice do valor que se quer encontrar no array;
        //se tiver mais de um índice com o mesmo valor, retornará o último encontrado;
        Console.WriteLine("LastIndexOf");
        int valor3=Array.LastIndexOf(vetor,3);
        Console.WriteLine("o valor indicado vem por último na posição {0}",valor3);
        Console.WriteLine("---------------------------------");


    }
}
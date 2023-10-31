using System;

class metodos {
    static void Main() {
        int[] vetor=new int[]{1,2,3,4,5};
        int[,] matriz=new int[2,5]{{6,7,8,9,10},{11,12,13,14,15}};

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdvetor=vetor.GetLongLength(0);
        Console.WriteLine("a qtd de elementos do vetor é {0}",qtdvetor);
        Console.WriteLine("------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int menorivetor=vetor.GetLowerBound(0);
        int menorimatriz=matriz.GetLowerBound(0);
        Console.WriteLine("o menor índice do vetor é {0} e da matriz é {1}",menorivetor,menorimatriz);
        Console.WriteLine("------------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int maiorivetor=vetor.GetUpperBound(0);
        int maiorimatriz=matriz.GetUpperBound(1);
        Console.WriteLine("o maior índice do vetor é {0} e da matriz é {1}",maiorivetor,maiorimatriz);
        Console.WriteLine("------------------------------------------");
    }
}
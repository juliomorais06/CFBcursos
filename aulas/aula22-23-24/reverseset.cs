using System;

class metodos {
    static void Main() {
        int[] vetor=new int[]{1,2,3,4,3};
        int[] vetor2=new int[5];
        int[,] matriz=new int[2,5]{{6,7,8,9,10},{11,12,13,14,15}};

        //public static void Reverse(array);
        Array.Reverse(vetor);
        foreach(int n in vetor) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------");

        //public void SetValue(object valor , long pos);
        vetor2.SetValue(99,0);
        for(int i=0;i<vetor2.Length;i++) {
            vetor2.SetValue(0,1);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n2 in vetor2) {
            Console.WriteLine(n2);
        }

        int[] vet1=new int[]{1,1,1};
        int[] vet2=new int[]{2,2,2};
        int[] vet3=new int[]{3,3,3};
        //public static void Sort(array);
        Array.Sort(vet1);
        Array.Sort(vet2);
        Array.Sort(vet3);
        Console.WriteLine("vet1");
        foreach(int v1 in vet1) {
            Console.WriteLine(v1);
        }
                Console.WriteLine("vet2");
        foreach(int v2 in vet2) {
            Console.WriteLine(v2);
        }
                Console.WriteLine("vet3");
        foreach(int v3 in vet3) {
            Console.WriteLine(v3);
        }
    }
}
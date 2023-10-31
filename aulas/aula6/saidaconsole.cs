using System;
class saidaconsole
{
    static void Main()
    {
        int n1, n2, n3;
        n1=10; n2=20; n3=30;

        Console.WriteLine("\t"+n1+" \n"+n2+"\n "+n3);
        
        //modelo de índices
        // \n= enter \t= tab
        Console.Write("\nn1{0}\n \nn2{1}\n \nn3{2}\n",n1,n2,n3);
        Console.Write("{0}, {1}, e {2}",n1,n2,n3);
    }
}
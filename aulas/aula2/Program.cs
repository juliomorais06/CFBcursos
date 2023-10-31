using System;

namespace aula2
{
    class programa
    {
        static void Main(string[] args)
        {
            Console.Write("Julio");
            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
        }
    }
}   
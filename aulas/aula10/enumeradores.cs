using System;

class enumeradores
{   
    enum diassemana{domingo,segunda,terça,quarta,quinta,sexta,sábado};

    static void Main()
    {
        diassemana d1 = diassemana.domingo;
        diassemana d2 = diassemana.segunda;
        diassemana d3 = diassemana.terça;
        diassemana d4 = (diassemana)3;
        diassemana d5 = (diassemana)4;
        int d6 = (int)diassemana.sexta;
        diassemana d7 = (diassemana)6;

        Console.Write(d2+"\n");
        Console.Write(d7+"\n");
        Console.Write(d6);
    }
}
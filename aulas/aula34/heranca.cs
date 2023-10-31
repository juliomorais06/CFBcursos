//herança de classes
//é um recurso da programação orientada à objetos onde uma classe filha (derivada) herda membros de uma classe pai (base)
//classe derivada também pode ter seus membros próprios

using System;

class Veiculo{
    public int rodas;
    public int velmax;
    public bool ligado;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public string getLigado(){
        if(ligado){
            return "sim";
        }else{
            return "não";
        }
    }
}
class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velmax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

class Aula34{

    static void Main(){
        Carro c1=new Carro("Rapidão","Vermelho");

        Console.WriteLine("Cor.......: {0}",c1.cor);
        Console.WriteLine("Nome......: {0}",c1.nome);
        Console.WriteLine("Rodas.....: {0}",c1.rodas);
        Console.WriteLine("VelMax....: {0}",c1.velmax);
        Console.WriteLine("Ligado....: {0}",c1.getLigado());
    }
}

using System;

class Veiculo{
    private int rodas;
    public int velmax;
    public bool ligado;
    
    public Veiculo(int rodas){
        this.rodas=rodas;
    }
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        }else if(rodas>40){
            this.rodas=40;
        }else{
            this.rodas=rodas;
        }
    }
    public string getLigado(){
        return (ligado?"sim":"não"); //o operador ternário (?) pode substituir o if
        /*if(ligado){
            return "sim";
        }else{
            return "não";
        }*/
    }
}
class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){ //fazer a referência (:) à classe base e iniciar com um argumento
        desligar();
        velmax=120;
        this.nome=nome;
        this.cor=cor;
    }
}
class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("carro de combate","verde"){
        setRodas(6);
        municao=100;
    }
}

class Aula34{

    static void Main(){
        Carro c1=new Carro("Rapidão","Vermelho");
        Carro cc1=new Carro("Monstão","verde");

        c1.ligar();

        Console.WriteLine("Cor.......: {0}",c1.cor);
        Console.WriteLine("Nome......: {0}",c1.nome);
        Console.WriteLine("Rodas.....: {0}",c1.getRodas());
        Console.WriteLine("VelMax....: {0}",c1.velmax);
        Console.WriteLine("Ligado....: {0}",c1.getLigado());
        Console.WriteLine("--------------------------------\n");

        Console.WriteLine("Cor.......: {0}",cc1.cor);
        Console.WriteLine("Nome......: {0}",cc1.nome);
        Console.WriteLine("Rodas.....: {0}",cc1.getRodas());
        Console.WriteLine("VelMax....: {0}",cc1.velmax);
        Console.WriteLine("Ligado....: {0}",cc1.getLigado());
    }
}

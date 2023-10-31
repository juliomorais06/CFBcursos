using System;

class Jogador{
   //membros da classe
    private int energia; //nesse caso só pode ser acessado dentro da classe
    private string nme;
    public Jogador(string nome){ //(parâmetro)
        this.nme = nome;
        energia=100;
    }
    public int getEnergia(){ //métodos
        return energia;
    }
    public string getNome(){
        return nme;
    }
    public void setEnergia(int e){
        if(e<0){
            if(energia+e<0){
                energia=0;
            }else{
                energia+=e;
            }
        }else if(e>0){
            if(energia+e>100){
                energia=100;
            }else{
                energia+=e;
            }
        }
    }
}

class Aula33{
    static void Main(){
        //instanciar um objeto para a classe //new aloca a memória para Jogador//tipo(Jogador)+nome=new+classe(Jogador)
        Jogador j1=new Jogador("Julio");

        j1.setEnergia(-50);
        j1.setEnergia(-60);

        Console.WriteLine("Nome...: {0}",j1.getNome());
        Console.WriteLine("Energia: {0}",j1.getEnergia());
    }
}
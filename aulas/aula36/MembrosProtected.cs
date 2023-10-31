using System;

class Veiculo{//classe base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velmax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }

    class Carro:Veiculo{//derivada de veículo
        public string nome;
        public Carro(string nome, int vm):base(vm){
            this.nome = nome;
            this.velMax = vm;
            ligado = true;
        }
    }
    class MembrosProtected{
        static void Main(){
            Carro carro = new Carro("Celta", 120);
            Console.WriteLine("Nome.............: {0}", carro.nome);
            Console.WriteLine("Velocidade Máxima: {0}", carro.getVelMax());
            Console.WriteLine("Ligado...........: {0}", carro.getLigado());
        }
    }
}
using System;

struct Carro{
    public string modelo;
    public string cor;
    public void info(){
        Console.WriteLine("Marca: {0} | Modelo: {1}\n-----------------", this.modelo, this.cor);
    }
}

class aula45{
    static void Main(){
        Carro[] carros = new Carro[4];

        carros[0].modelo = "Golf";
        carros[0].cor = "Prata";

        carros[1].modelo = "Jetta";
        carros[1].cor = "Preto";

        carros[2].modelo = "Argo";
        carros[2].cor = "Azul";

        carros[3].modelo = "HRV";
        carros[3].cor = "Vermelho";

        for(int i = 0; i < carros.Length; i++){
            carros[i].info();  
        }
    }
}
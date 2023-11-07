using System;

//aula para demonstração que sealed não pode ser herdado. Neste exemplo o programa gerará um erro e não é compilado.
sealed class Veiculo{

}
class Carro:Veiculo{

}
class Sealed{ //classes seladas não podem ser herdadas.
    static void Main(){
        Carro c1 = new Carro();
    }
}
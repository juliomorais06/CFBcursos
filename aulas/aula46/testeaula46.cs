using System;

class galinha{
    private string nomeGalinha;
    private int numOvo;
    public galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public ovo botar(){
        numOvo++;
        return new ovo(numOvo, nomeGalinha);
    }
}
class ovo{
    private int numOvo;
    private string minhagalinha;
    public ovo(int numOvo, string minhagalinha){
        this.minhagalinha = minhagalinha;
        this.numOvo = numOvo;
        Console.WriteLine("Numero ovo: {0} - {1}", numOvo, minhagalinha);
    }
}
class teste{
    static void Main(){
        galinha d1 = new galinha("Tata");
        galinha d2 = new galinha("Tita");
        d1.botar();
        d1.botar();
        d2.botar();
        d2.botar();
        d2.botar();
    }
}
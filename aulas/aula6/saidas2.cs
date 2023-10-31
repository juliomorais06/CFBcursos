using System;
class saidaconsole{
    static void Main()
    {
        double ValorCompra=5.50;
        double ValorVenda;
        double lucro=0.1;
        string Produto="Pastel";

        ValorVenda=(ValorCompra*lucro)+ValorCompra;

        // :c coloca valor monetário e :p coloca o valor em porcentagem
        Console.WriteLine("Produto---------{0,20}",Produto);
        Console.WriteLine("Valor Compra----{0,20:c}", ValorCompra);
        Console.WriteLine("Lucro-----------{0,20:p}", lucro);
        Console.WriteLine("Valor de Venda--{0,20:c}", ValorVenda);

    }
}
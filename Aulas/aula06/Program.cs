using System;

namespace aula06
{
    class Principal
    {
        static void Main(string[] args)
        {

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.5;
            string product = "sorvete";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("\tO produto..........:[{0,7}]", product);
            Console.WriteLine("\tValor da compra....:[{0,7:c}]", valorCompra);
            Console.WriteLine("\tLucro:.............:[{0,7:p}]", lucro);
            Console.WriteLine("\tValor de venda.....:[{0,7:c}]", valorVenda);

        }
    }
}

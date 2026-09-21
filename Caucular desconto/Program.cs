using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caucular_desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double precoProduto, descontoPreco;
            /* Calcular desconto
            Um produto com preço acima de de 100 reaos tem um desconto de 10%. caso contrário, o desconto é de 5%.
             Dado o preço, calcule o valor do desconto.
            * entrada: 120
            * Saida esperada: 12 reais de desconto.
          */
            Console.Write("Digite o valor do produto: ");
            precoProduto = double.Parse(Console.ReadLine());

            if (precoProduto > 100)
            {

                descontoPreco = precoProduto * 0.10;
                Console.WriteLine(descontoPreco + " reais de desconto");
            }
            else if (precoProduto < 100)
            {
                descontoPreco = precoProduto * 0.5;
                Console.WriteLine(descontoPreco + " reais de desconto");
            }
         




        }
    }
}

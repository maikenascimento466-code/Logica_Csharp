using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_6_C_
{
    internal class Program
    { /* Faça um algoritimo que leia o valor de um produto e determine o valor que deve ser pago
         conforme a escolha da forma de pagamento. */
        static void Main(string[] args)
        {
            double produto, valorPago;
            int opcao;

            Console.Write("Digite o valor do produto: ");
            produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - À vista em dinheiro");
            Console.WriteLine("2 - À vista no cartão");
            Console.WriteLine("3 - Em 2x no cartão");
            Console.WriteLine("4 - Em 3x ou mais no cartão");

            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                valorPago = produto - (produto * 0.10);
            }
            else if (opcao == 2)
            {
                valorPago = produto - (produto * 0.05);
            }
            else if (opcao == 3)
            {
                valorPago = produto;
            }
            else
            {
                valorPago = produto + (produto * 0.10);
            }

            Console.WriteLine("Valor a pagar: R$ " + valorPago.ToString("F2"));
        }
    }
}
    


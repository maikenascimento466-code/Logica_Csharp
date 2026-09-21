using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_7_C_
{  /* Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor
      de B por A e imprima na tela os valores.  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, aux;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            aux = A;
            A = B;
            B = aux;

            Console.WriteLine("Valor de A: " + A);
            Console.WriteLine("Valor de B: " + B);
        }
    }
}

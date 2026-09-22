using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3_C_
{ /* Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se
ambos são VERDADEIRO ou FALSO. */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A, B;

            Console.Write("Digite o primeiro valor (true/false): ");
            A = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (true/false): ");
            B = bool.Parse(Console.ReadLine());

            if (A && B)
            {
                Console.WriteLine("Ambos são VERDADEIRO.");
            }
            else if (!A && !B)
            {
                Console.WriteLine("Ambos são FALSO.");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes.");
            }
        }
    }
}

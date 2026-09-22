using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_1_C_
{ 
    internal class Program
    {  /* Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B
         forem iguais, deverá somar os dois valores, caso contrário devera multiplicar A por B. 
        Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C imprimir seu valor na tela. */
 
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }

            Console.WriteLine("O valor de C é: " + C);
        }
    }
}

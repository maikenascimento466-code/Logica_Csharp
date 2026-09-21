using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2_C_
{
    internal class Program
    { /* Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de
um usuário, calcule quantos salários mínimos esse
usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$
1.518,00). */
        static void Main(string[] args)
        {
            double salarioMinimo = 1518.00;
            double salarioUsuario;
            double quantidade;

            Console.Write("Digite o seu salário: ");
            salarioUsuario = double.Parse(Console.ReadLine());

            quantidade = salarioUsuario / salarioMinimo;

            Console.WriteLine("Você ganha " + quantidade.ToString("F2") + " salários mínimos.");
        }
    

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_8_C_
{
    internal class Program
    { /* Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela
         quantos anos, meses e dias essa pessoa ja viveu. Leve em
         consideração o ano com 365 dias e o mês com 30 dias. */
        static void Main(string[] args)
        {
            int anoNascimento;
            int anos, meses, dias;

            Console.Write("Digite o ano em que você nasceu: ");
            anoNascimento = int.Parse(Console.ReadLine());

            anos = 2026 - anoNascimento;

            meses = anos * 12;
            dias = anos * 365;

            Console.WriteLine("Você já viveu aproximadamente:");
            Console.WriteLine(anos + " anos");
            Console.WriteLine(meses + " meses");
            Console.WriteLine(dias + " dias");
        }
    }
}
    


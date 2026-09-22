using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_9_C_
{
    internal class Program
    { /* Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a
        temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.   */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é: " + celsius);
            Console.ReadKey();
        }
    }
}

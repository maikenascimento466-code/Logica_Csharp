using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Digite seu peso (kg): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso ideal (parabéns)");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("Obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("Obesidade grau III (mórbida)");
            }


        }
    }
}





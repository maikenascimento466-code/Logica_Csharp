using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_11_C_
{
    internal class Program
    {       /* Faça um um algoritimo que efetue o calculo do salario de um professor, as informações 
             fornecudas serão: valor da hora aula, números de aulas lecionadas, 
            percentual de desconto do inss e percentual de desconto do INSS. imprima o salário liquido final.         */
        static void Main(string[] args)
        {
            double valorHora, aulas, descontoINSS;
            double salarioBruto, desconto, salarioLiquido;

            Console.Write("Digite o valor da hora aula: ");
            valorHora = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de aulas no mês: ");
            aulas = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto do INSS: ");
            descontoINSS = double.Parse(Console.ReadLine());

            salarioBruto = valorHora * aulas;
            desconto = salarioBruto * descontoINSS / 100;
            salarioLiquido = salarioBruto - desconto;

            Console.WriteLine("Salário líquido: R$ " + salarioLiquido.ToString("F2"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_peças
{
    internal class Program
    {  /* uma fábrica tem uma linha de produção capaz de 400 peças/dia. Um funcionário controla a qualidade,
        cadastrando o número da peças e o seu estado (aprovado ou reprovado). Criar um programa para cadastrar 
        o controle de qualidade e imprimir o total de peças aprovadas e reprovadas mo final do dia. */
        static void Main(string[] args)
        {
            int contador, reprovadas, aprovadas, numPecas;
            string estado;
            contador = 1;
            reprovadas = 0;
            aprovadas = 0;
            while(contador <= 40)
            {
                Console.WriteLine("Digite o numero da " + contador + " peça: ");
            numPecas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite se a peça está aprovada ou reprovada( a para aprovada / r para reprovada): ");
            estado = Console.ReadLine();

            if (estado == "a")
            {
                aprovadas++;
            }
            else
            {
                reprovadas++;
            }
            contador++;
        }
          Console.WriteLine("total de peças aprovadas: " + aprovadas);
            Console.WriteLine("total de peças reprovadas: " + reprovadas);
            





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_12_C_
{
    internal class Program
    {  /* Faça um algoritmo que calcule a quantidade de litros de combustível gastos em
      uma viagem, sabendo que o carro faz 12km com um litro. Deve-se fornecer ao
      usuário o tempo que será gasto na viagem a sua velocidade média, distância
      percorrida e a quantidade de litros utilizados para fazer a viagem.
      Fórmula: distância = tempo x velocidade.
      litros usados = distância / 12    */
        static void Main(string[] args)
        {
            double tempo, velocidade, distancia, litros;

            Console.Write("Digite o tempo da viagem (em horas): ");
            tempo = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média (km/h): ");
            velocidade = double.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros = distancia / 12;

            Console.WriteLine("Distância percorrida: " + distancia + " km");
            Console.WriteLine("Litros utilizados: " + litros.ToString("F2") + " L");
        }
    }
}

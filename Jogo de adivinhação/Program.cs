using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_adivinhação
{
    internal class Program
    {
        /* Simular o jogo de adivinhação: o jogador 1 escolhe um número escolhido pelo jogador 2
          insere números na tentativa de acertar, o algoritivo deve informar que el acertou o número x
          (escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador 2). */          
        static void Main(string[] args)
        {
            int palpite = 0, tentativas = 0;
           Console.WriteLine("Jogador 1 escollha um número de 1 a 10");
            int numeroSecreto = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("jogador 2, tente adivinhar o número!");

            while (palpite != numeroSecreto)
            {
                tentativas++;
                Console.Write($"Tentativa {tentativas}: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MAIOR.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MENOR.");
                }
            }

            // --- FIM DO JOGO ---
            Console.WriteLine("\n=================================");
            Console.WriteLine("Parabéns! Você acertou!");
            Console.WriteLine($"O número secreto era: {numeroSecreto}");
            Console.WriteLine($"Total de tentativas do Jogador 2: {tentativas}");
            Console.WriteLine("=================================");
        }


    }
    }


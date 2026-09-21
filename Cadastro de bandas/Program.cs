using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_bandas
{
    internal class Program
    { /*
            Se / enquamto /para / caso
            if /while / for/ swith

        Crie um sistema de cadastro de álbuns de um artista / banda em que será possível cadastrar um número x 
            de músicas informada pelo usuário. crie um menu de opções pra isso. */
        static void Main(string[] args)
        {
            int opcao;

            while (opcao != 4) ;
            {
                Console.Clear();  // limpar tela
                Console.ForegroundColor = ConsoleColor.Yelow;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");


                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" 1 - Cadastrar àlbum da banda");
                Console.WriteLine(" 2 - Cadastrar Album do artista");
                Console.WriteLine(" 3 - Cadastrar Músicas");
                Console.WriteLine(" 4 - sarir do Programa");
                Console.WriteLine(" ----> ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                   
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;
                
                }
            }
        }
    






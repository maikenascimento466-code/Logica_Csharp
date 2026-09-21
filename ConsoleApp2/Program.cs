using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdastro_de_bandas
{
    internal class Program
    {  /* controle de Bandas   */
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1 - nome do artista: ");
            Console.WriteLine(" 2 - Cadastrar Álbum do Artista: "); // Ano, Nome, Qtd de album, qtd vendas
            Console.WriteLine(" 3 - Cadastrar Músicas: "); //
            Console.WriteLine(" 4 - sair do Programa");
            Console.WriteLine(" ----> ");
            Console.ResetColor();


        }
    }
}

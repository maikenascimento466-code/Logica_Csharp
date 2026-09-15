using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            int idade;
                // variável cadeia // variável inteiro
            Console.WriteLine("Digite seu nome: "); //escreva
           nome = Console.ReadLine(); // Leia
                   Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine()); // converte o que digitar para inteiro
                 Console.WriteLine("Parabéns " + nome + " Você acabou de ganhar uma coca-cola");
            Console.WriteLine("\n Você possui " + idade + " anos, beba mais água");


        }
    }
}

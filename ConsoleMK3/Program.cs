namespace ConsoleMK3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number, number2, soma;

            Console.WriteLine("Digite o primeiro numero: "); // leia
            number = int.Parse(Console.ReadLine()); // escreva
            Console.WriteLine("Digite o segundo numero"); // leia
            number2 = int.Parse(Console.ReadLine());
            soma = number - number2;
            Console.WriteLine("o resultado da subtraçaõ é; ", + soma);
        }
    }
}

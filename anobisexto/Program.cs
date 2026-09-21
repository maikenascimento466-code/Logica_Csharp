using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anobisexto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 

           ano bisexto
            Determine se um ano é bissexto. Um ano bissexto se for divisivel por 4, mas não por 100, a não
             ser que seja divisível por 400.
        */
            int ano;
            Console.Write("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("Ano bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine("ano bissexto");
            }
            else { Console.WriteLine("não bissexto"); }


        }

    }
}

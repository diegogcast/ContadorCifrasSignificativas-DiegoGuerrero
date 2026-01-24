using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorCifrasSignificativas
{
    class Program
    {
    
        static void Main()
        {
            Console.WriteLine("CONTADOR DE CIFRAS SIGNIFICATIVAS");
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            int count = ContarCifrasSignificativas(input);

            Console.WriteLine($"Cifras significativas: {count}");
            Console.ReadKey();
        }

        static int ContarCifrasSignificativas(string num)
        {
            num = num.Trim();

            if (num.StartsWith("-") || num.StartsWith("+"))
                num = num.Substring(1);

            if (num.Contains("."))
            {
                num = num.TrimStart('0');
                num = num.Replace(".", "");
                return num.Length;
            }
            else
            {
                num = num.TrimStart('0');
                num = num.TrimEnd('0');

                return num.Length;
            }
        }
    }
}

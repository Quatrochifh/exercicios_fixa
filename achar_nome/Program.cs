using System;

namespace achar_nome
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes = null;
            nomes = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Digite algum nome:");
                nomes[i] =  Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Digite mais um nome");
            string nome_b = Console.ReadLine();

            
            if (nome_b == nomes[0])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[1])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[2])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[3])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[4])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[5])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[6])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[7])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[8])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (nome_b == nomes[9])
            {
                Console.WriteLine("ACHEI");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.WriteLine("okay... não achei...");
                Console.ResetColor();
            }
           Console.ResetColor();
        }
    }
}

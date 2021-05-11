using System;

namespace ao_contrario
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] numeros = null;
            numeros = new int[15];

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite {(i + 1)}º numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 14; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}

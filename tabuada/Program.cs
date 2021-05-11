using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Tabuada do 1 ao 10\n");
           
            for (var i = 1; i <= 10 ; i++)
            {
                Console.WriteLine($"Tabuada do {i}\n");

                for (var m = 1; m < 11; m++)
                {
                    Console.WriteLine($"{i} x {m} = {i*m}");
                }
            };
        }
    }
}

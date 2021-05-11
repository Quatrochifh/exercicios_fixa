using System;

namespace maior_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = null;
            valores = new double[10];
            double menor = 0;
            double maior = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome do {(i + 1)}º valor");
                valores[i] = float.Parse(Console.ReadLine());
                if(i == 0)
                {
                    menor = valores[i];
                    maior = valores[i];
                }

                if(valores[i] > maior)
                {
                    maior = valores[i];
                }

                if(valores[i] < menor)
                {
                    menor = valores[i];
                }
            }
            Console.WriteLine($"O menor valor é {menor}, e o maior valor é {maior}");
        }
    }
}

using System;

namespace produto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa tarde, me informe algumas coisas");
            Console.WriteLine("qual o nome do produto?");
            string produto = (Console.ReadLine());
            
            Console.WriteLine("quantos produtos você adquiriu?");
            int quantidadeadquirida = int.Parse(Console.ReadLine());

            Console.WriteLine("qual o preço do produto adquirido?");
            int preçounitário = int.Parse(Console.ReadLine());

            int preçototal =  quantidadeadquirida * preçounitário;
            Console.WriteLine($"seu valor sem desconto é de {preçototal}");

            // int desconto1 = 2/100;
            // int desconto2 = 3/100;
            // int desconto3 = 5/100;

            if (preçototal <= 5)
            {
                int desconpre = (2/100 - preçototal);
                Console.WriteLine($"o valor é de {desconpre}");
            }
            else if(preçototal > 5 && preçototal <= 10)
            {
                int desconpre2 = (3/100 - preçototal );
                Console.WriteLine($"o valor é de {desconpre2}");
            }

            else
            {
                int desconpre3 = (5/100 - preçototal);
                Console.WriteLine($"o valor é de {desconpre3}");
            }
        }
    }
}

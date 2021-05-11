using System;

namespace Ler_ano
{
    class Program
    {
        static void Main(string[] args)
        {

            //feito
            Console.WriteLine("boa tarde, qual o seu nome?");
            string nome = (Console.ReadLine());

            Console.WriteLine("Bem vindo " + nome + " em que ano você nasceu?");
            int nascimento =  int.Parse(Console.ReadLine());

            int anonosso = DateTime.Now.Year;

            int idade = anonosso - nascimento;
            Console.WriteLine("A sua idade é de: " + idade + " anos");


           if (idade >= 18)
           {
            
               Console.WriteLine("você pode votar");
           }

           else 
           {
               Console.WriteLine("você não tem idade para votar");
           }
            
        }
    }
}

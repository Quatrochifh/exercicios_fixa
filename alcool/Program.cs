using System;

namespace alcool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustivel você quer abastecer? sendo (a) álcool ou (g) gasolina");
            string combustivel = Console.ReadLine().ToLower();
            Console.WriteLine ("quantos litros deseja abastecer?");
            double litros = double.Parse(Console.ReadLine());

            double alcool = 4.90;
            double gasolina =5.30;

            switch (combustivel)
            {
                case "a":
                    if (litros <= 20)
                    {
                      double litroalcool = (alcool*litros);
                      double resultadoal = litroalcool*0.97;  
                      Console.WriteLine($"o valor é de {resultadoal}");
                    }else
                    {
                      double litroalcool = (alcool*litros);
                      double resultadoal = litroalcool*0.95;  
                      Console.WriteLine($"o valor é de {resultadoal}");
                    }
                    break;

                case "g":
                if (litros > 20)
                {
                    double litrogasolina = (gasolina*litros);
                    double resultadoga = litrogasolina*0.96;  
                    Console.WriteLine($"o valor é de {resultadoga}");
                }else
                {
                    double litrogasolina = (gasolina*litros);
                    double resultadoga = litrogasolina*0.94;  
                    Console.WriteLine($"o valor é de {resultadoga}");
                }
                break;
                default:
                break;
            }
        }
    }
}

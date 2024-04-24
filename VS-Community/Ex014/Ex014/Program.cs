using System;
using System.Globalization;

namespace CálculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distancia;
            double ConsumoMedio, ConsumoRespectivoDistancia;

            Distancia = int.Parse(Console.ReadLine());
            ConsumoRespectivoDistancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ConsumoMedio = Distancia / ConsumoRespectivoDistancia;

            Console.WriteLine(ConsumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}

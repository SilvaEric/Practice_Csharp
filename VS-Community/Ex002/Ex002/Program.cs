using System;
using System.Globalization;

namespace ÁreaDoCirculo
{
    class Program
{
        static void Main(string[] args)
        {
            double Area, Raio, N, RaioAoQuadrado;
            N = 3.14159;
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            RaioAoQuadrado = Math.Pow(Raio, 2);
            Area = N * RaioAoQuadrado;
            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture ));


        }
}
}

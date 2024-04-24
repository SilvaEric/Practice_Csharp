using System;
using System.Globalization;

namespace Média2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, PesoA, PesoB, PesoC, Media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PesoA = 2.0;
            PesoB = 3.0;
            PesoC = 5.0;
            Media = ((A * PesoA) + (B * PesoB) + (C * PesoC)) / (PesoA + PesoB + PesoC);

            Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}


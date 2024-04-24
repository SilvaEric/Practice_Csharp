using System;

namespace Diferença
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            Diferenca = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + Diferenca);
        }
    }
}
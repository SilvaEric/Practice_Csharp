using System;
using System.Globalization;

namespace CálculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tempo, Distancia;

            Distancia = int.Parse(Console.ReadLine());
            Tempo = Distancia * 2;

            Console.WriteLine(Tempo + " minutos");


        }
    }
}

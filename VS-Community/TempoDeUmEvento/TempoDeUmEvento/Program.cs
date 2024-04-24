using System;
using System.Globalization;

namespace exercício
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            Console.WriteLine("Dia ");

            int DiaInicio = int.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(":");

            Console.WriteLine("Dia ");

            int DiaFim = int.Parse(Console.ReadLine());

            string[] vet2 = Console.ReadLine().Split(":");

            int HoraInicio = int.Parse(vet[0]);
            int MinutoInicio = int.Parse(vet[1]);
            int SegundoInicio = int.Parse(vet[2]);

            int HoraFim = int.Parse(vet2[0]);
            int MinutoFim = int.Parse(vet2[1]);
            int SegundoFim = int.Parse(vet2[2]);

            int MaxDias = 29;
            int MaxHoras = 23;
            int MaxMinutos = 59;
            int MaxSegundos = 59;

            int DifDias = Math.Abs((MaxDias - DiaInicio) - (MaxDias - DiaFim));
            int DifHoras =Math.Abs((MaxHoras - HoraInicio) - (MaxHoras - HoraFim));
            int DifMinutos = Math.Abs((MaxMinutos - MinutoInicio) - (MaxMinutos - MinutoFim));
            int DifSegundos = Math.Abs((MaxSegundos - SegundoInicio) - (MaxSegundos - SegundoFim));

            Console.WriteLine(DifDias + " dias(s)");
            Console.WriteLine(DifHoras + " hora(s)");
            Console.WriteLine(DifMinutos + " minuto(s)");
            Console.WriteLine(DifSegundos + " segundo(s)");




        }
    }
}
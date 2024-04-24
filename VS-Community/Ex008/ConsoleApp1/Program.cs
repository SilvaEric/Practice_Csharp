using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, HorasTrabalhadas;
            double ValorHora, Salario;

            Numero = int.Parse(Console.ReadLine());
            HorasTrabalhadas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Salario = HorasTrabalhadas  * ValorHora;

            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

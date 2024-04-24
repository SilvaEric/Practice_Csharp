using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double Entrada, SalarioReajustado, Reajuste, Percentual;

        Entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (Entrada <= 400.00)
        {
            Percentual = 0.15;
            Reajuste = Entrada * Percentual;
            SalarioReajustado = Entrada + Reajuste;
        }
        else if(Entrada <= 800.00 )
        {
            Percentual = 0.12;
            Reajuste = Entrada * Percentual;
            SalarioReajustado = Entrada + Reajuste;
        }
        else if (Entrada <= 1200.00)
        {
            Percentual = 0.10;
            Reajuste = Entrada * Percentual;
            SalarioReajustado = Entrada + Reajuste;
        }
        else if (Entrada <= 2000.00)
        {
            Percentual = 0.07;
            Reajuste = Entrada * Percentual;
            SalarioReajustado = Entrada + Reajuste;
        }
        else
        {
            Percentual = 0.04;
            Reajuste = Entrada * Percentual;
            SalarioReajustado = Entrada + Reajuste;
        }
        Console.WriteLine("Novo salario : " + SalarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho : " + Reajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual : " + Percentual * 100 + " %");
    }

}
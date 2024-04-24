using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double preco, total;
        int codigo, quant;

        string[] vet = Console.ReadLine().Split(' ');

        codigo = int.Parse(vet[0]);
        quant = int.Parse(vet[1]);

        switch (codigo)
        {
            case 1:
                preco = 4.0;
                break;
            case 2:
                preco = 4.5;
                break;
            case 3:
                preco = 5.0;
                break;
            case 4:
                preco = 2.0;
                break;
            default:
                preco = 1.5;
                break;
        }
        total = quant * preco;

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }

}

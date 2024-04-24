using System;
using System.Globalization;

namespace course
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa ? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Preço de um produto: ");
            double Produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma Linha)");
            string[] vet = Console.ReadLine().Split(' ');

            string n = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("Você digitou :");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(Produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(n);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}

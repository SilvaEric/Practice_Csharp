using System;
using System.Globalization;

namespace exercício
{
    class Program
    {
        static void Main(string[] args) 
      
        {
            Console.WriteLine("Insira a largura, comprimento e o preço do metro quadrado, do terreno, respectivamente:");
            
            string[] vet = Console.ReadLine().Split(' ');

            double largura, comprimento, valor, area, preco;

            largura = double.Parse(vet[0], CultureInfo.InvariantCulture);
            comprimento = double.Parse(vet[1], CultureInfo.InvariantCulture);
            valor = double.Parse(vet[2], CultureInfo.InvariantCulture);
            area = largura * comprimento ;
            preco = valor * area;
            
            Console.WriteLine("ÁREA = " + area.ToString("F2",CultureInfo.InvariantCulture ));
            Console.WriteLine("PRECO =  " + preco.ToString("F2", CultureInfo.InvariantCulture));
            
                Console.ReadLine();

         }
    }

}
using System; 

class URI
{

    static void Main(string[] args)
    {
        int num, num2;

        string[] vet = Console.ReadLine().Split(' ');

        num = int.Parse(vet[0]);

        num2 = int.Parse(vet[1]);

        if (num2 > num && num2 % num == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        if (num > num2 && num % num2 == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}
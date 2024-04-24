using System;

class URI
{

    static void Main(string[] args)
    {
        double a, b, c;

        string[] vet = Console.ReadLine().Split(' ');

        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

        if ( b > a && b > c && c >= a )
        {
            a = c;
            b = a;
            c = b;
        }
        if (b > a && b > c && c <= a)
        {
            a = b;
            b = a;
        }
        if (c > a && c > b && a >= b)
        {
            a = b;
            b = c;
            c = a;
        }
        if (c > a && c > b && a <= b)
        {
            a = c;
            c = a;
        }
        if (a > b && a > c && b <= c)
        {
            b = c;
            c = b;
        }
        if ( a > b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");

        }
        else
        {
            if ( a * a == b * b + c * c) 
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && a == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

        }
    }

}
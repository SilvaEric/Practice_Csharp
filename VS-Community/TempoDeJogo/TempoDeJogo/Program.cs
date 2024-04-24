using System;

class URI
{

    static void Main(string[] args)
    {
        int HoraInicio, HoraFim, Total;

        string[] vet = Console.ReadLine().Split(' ');

        HoraInicio = int.Parse(vet[0]);
        HoraFim = int.Parse(vet[1]);

        if (HoraInicio <= 12 && HoraFim >= 12)
        {
            Total = HoraFim - HoraInicio  ;
        }
        else if (HoraInicio >= 12 && HoraFim <= 12)
        {
            Total = 24 - (HoraInicio - HoraFim);
        }
        else if (HoraInicio == HoraFim)
        {
            Total = 24;
        }
        else if (HoraInicio <= 12 && HoraFim <= 12)
        {
            Total = 24 - Math.Abs(HoraInicio - HoraFim);
        }
        else 
        {
            Total = 24 - Math.Abs(HoraInicio - HoraFim);
        }

        Console.WriteLine("O JOGO DUROU " + Total + " HORA(S)");
    }

}
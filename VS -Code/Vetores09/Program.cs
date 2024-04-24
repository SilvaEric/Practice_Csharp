using System.Globalization;
int n = int.Parse(Console.ReadLine());
int lucro1, lucro2, lucro3;
double lucro, totalC, totalV, lucroT;
lucro1 = 0;
lucro2 = 0;
lucro3 = 0;
lucro = 0;
totalC = 0;
totalV = 0;
lucroT = 0;

for(int i = 0; i<n ; i++){
    string [] vet = Console.ReadLine().Split();
    lucro = double.Parse(vet[2],CultureInfo.InvariantCulture) - double.Parse(vet[1],CultureInfo.InvariantCulture);
    lucroT += lucro;
    totalC += double.Parse(vet[1],CultureInfo.InvariantCulture);
    totalV += double.Parse(vet[2],CultureInfo.InvariantCulture);
    if(lucro > (double.Parse(vet[1],CultureInfo.InvariantCulture) * 0.2)){
        lucro3++;
    }
    else if(lucro >= (double.Parse(vet[1],CultureInfo.InvariantCulture) * 0.1)){
        lucro2++;
    }
    else{
        lucro1++;
    }
}
Console.WriteLine("Lucro abaixo de 10%: " + lucro1);
Console.WriteLine("Lucro entre 10% e 20%: " + lucro2);
Console.WriteLine("Lucro acima de 20%: " + lucro3);
Console.WriteLine("Valor total de compra: " + totalC.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Valor total de venda: " + totalV.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Lucro total: " + lucroT.ToString("F2",CultureInfo.InvariantCulture));
using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] numeros = new double [n];

string [] vet = Console.ReadLine().Split(' ');

double soma = 0;

for(int i = 0; i < n; i++){
    numeros [i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
    soma += numeros[i];
}

double media = soma / n;
Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
for(int i = 0; i < n; i++){
    if(numeros[i] < media){
        Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
    }
}
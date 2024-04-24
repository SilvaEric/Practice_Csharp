using System.Globalization;

int n = int.Parse(Console.ReadLine());

double [] numeros = new double[n];

string[] vet = Console.ReadLine().Split(' ');

int ContPar = 0;

double SomaPar = 0;

for( int i = 0; i < n; i++){
    numeros [i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
    if(numeros[i] %2 ==0){
        ContPar ++;
        SomaPar += numeros[i];
    }
}

double media = SomaPar / ContPar;

Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
using System.Globalization;

int n, i, j, pos; 
string [] vet;
double maior;
double [] numeros;

n = int.Parse(Console.ReadLine());

vet = Console.ReadLine().Split(' ');

numeros = new double [n];

for(i = 0; i < n; i++){
    numeros [i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

pos = 0;
maior = 0.0;

for(j = 0; j < n; j++ ){
    if(numeros[j] > maior){
        maior = numeros[j];
        pos = j;
    }
}
Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine(pos);


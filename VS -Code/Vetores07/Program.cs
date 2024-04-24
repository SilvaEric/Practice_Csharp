using System.Globalization;
int n = int.Parse(Console.ReadLine());

string [] nome;
double [] sem1, sem2;

sem1 = new double[n];
sem2 = new double[n];
nome = new string[n];
int isem1 = 0;
int isem2 = 0;
int inome = 0;

for (int i = 0; i < n; i++){
    string [] a = Console.ReadLine().Split(' ');
    nome[inome] = a[0];
    sem1[isem1] = double.Parse(a[1], CultureInfo.InvariantCulture);
    sem2[isem2] = double.Parse(a[2], CultureInfo.InvariantCulture);
    isem1++;
    isem2++;
    inome++;
}
Console.WriteLine("Alunos aprovados:");
for(int j = 0; j<n; j++){
    double media = (sem1[j] + sem2[j])/2;
    if(media >= 6.0){
        Console.WriteLine(nome[j]);
    }
}
using System.Globalization;

double [,] m , a;

int lc = int.Parse(Console.ReadLine());
m = new double [lc,lc];
a = new double [lc,lc];

for(int i = 0; i < lc; i++){
    string [] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < lc; j++){
        m[i,j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
        a[i,j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
    }
}
int linha  = int.Parse(Console.ReadLine());
int coluna  = int.Parse(Console.ReadLine());
double soma = 0.0;

for(int i = 0; i < lc; i++){
    for(int j = 0; j < lc; j++){
        if(m[i,j] > 0){
            soma += m[i,j];
        }
        else{
            a[i,j] = m[i,j] * m[i,j]; 
        }
    }
}
Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

Console.Write("LINHA ESCOLHIDA: ");
for(int i = 0; i < lc; i++ ){
    Console.Write(m[linha,i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

Console.Write("COLUNA ESCOLHIDA: ");
for(int i = 0; i < lc; i++ ){
    Console.Write(m[i,coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

Console.Write("DIAGONAL PRINCIPAL: ");
for(int i = 0; i < lc; i++ ){
    Console.Write(m[i,i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

Console.WriteLine("MATRIZ ALTERADA:");
for(int i = 0; i < lc; i++){
    for(int j = 0; j < lc; j++){
        Console.Write(a[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}

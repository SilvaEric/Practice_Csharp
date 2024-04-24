int [,] M;
int lc = int.Parse(Console.ReadLine());
M = new int [lc,lc];

for(int i = 0; i < lc; i++){
    string [] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < lc; j++){
        M[i,j]= int.Parse(vet[j]);
    }
}
int cont = 1;
int soma = 0;
for(int i = 0; i < lc; i++){
    for(int j = cont; j < lc; j++){
        soma += M[i, j]; 
    }
    cont += 1;
}
Console.WriteLine(soma);
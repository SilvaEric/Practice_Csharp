int [,] M;
int Lc  = int.Parse(Console.ReadLine());
M = new int [Lc, Lc];

for(int i = 0; i < Lc; i++){
    string [] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < Lc; j++){
        M[i,j] = int.Parse(vet [j]);
    }
}

for(int i = 0; i < Lc; i++){
    int soma = 0;
    for(int j = 0; j < Lc; j++){
        soma += M[i,j];
    }
    Console.WriteLine(soma);
}
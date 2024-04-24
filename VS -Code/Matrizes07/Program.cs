int [,] m, n;

int linha = int.Parse(Console.ReadLine());
int coluna = int.Parse(Console.ReadLine());

m = new int [linha, coluna];
n = new int [linha, coluna];
for(int i = 0; i < linha; i++){
    string [] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < coluna; j++){
        m[i,j] = int.Parse(vet[j]);
        n[i,j] = int.Parse(vet[j]);
    }
}

int Glinha = int.Parse(Console.ReadLine()) - 1;
int index = coluna -1;

for( int i = 0; i < coluna; i++){
    if(i == 0){
        n[Glinha,i] = m[Glinha,index];
    }
    else{
        n[Glinha, i]= m[Glinha,i -1];
    }
}


for(int i = 0; i < linha; i++){
    for(int j = 0; j < coluna; j++){
       Console.Write(n[i,j] + " ");
    }
    Console.WriteLine();
}
int l, c;
int [,] M;
string [] vet = Console.ReadLine().Split();
l = int.Parse(vet[0]);
c = int.Parse(vet[1]);
M = new int [l,c];
for( int i = 0 ; i< l; i++){
    vet = Console.ReadLine().Split();
    for(int j = 0; j < c; j++){
        M [i,j] = int.Parse(vet[j]);
    }
}
Console.WriteLine("VALORES NEGATIVOS:");
for( int i = 0; i< l; i++ ){
    for(int j = 0; j < c; j++ ){
        if(M[i,j] < 0){
            Console.WriteLine(M[i,j]);
        }
    }
}


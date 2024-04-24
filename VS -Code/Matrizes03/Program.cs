int [,] M;
int LC = int.Parse(Console.ReadLine());
M = new int [LC,LC];

for(int i = 0; i < LC; i++ ){
    string [] EntLine = Console.ReadLine().Split(' ');
    for(int j = 0; j < LC; j++){
        M[i, j] = int.Parse(EntLine[j]);
    }
}

for(int i = 0; i < LC; i++){
    int Maior = 0;
    for(int j = 0; j < LC; j++){
        if( M[i,j] > Maior){
            Maior = M[i,j];
        }
    }
    Console.WriteLine(Maior);
}
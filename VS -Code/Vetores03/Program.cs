int n = int.Parse(Console.ReadLine());
int [] A = new int [n];
int [] B = new int [n];
int [] C = new int [n];

for( int i = 2; i > 0; i-- ){
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < n ; j++){
        if(i == 2){
            A [j]= int.Parse(vet[j]);
        }
        else{
            B [j]= int.Parse(vet[j]);
        }
    }
    if(i == 1){
        for(int k = 0; k < n; k++){
            C[k] = A[k] + B[k];
            Console.Write(C[k] + " ");
         }
    }
}
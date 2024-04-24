int n = int.Parse(Console.ReadLine());

string[] nomes;
int [] idades;
nomes = new string[n];
idades = new int [n];
int armI = 0;
int armN = 0;
int idade = 0;
int pos=0;

for( int i = 0; i<n ; i++){
    string [] A = Console.ReadLine().Split(' ');
    nomes[armN] = A[0];
    idades[armI] = int.Parse(A[1]);
    armN++;
    armI++;
}

for(int k = 0; k< n; k++){
    if(idades[k] > idade){
        idade = idades[k];
        pos = k;
    }
}
Console.Write("Pessoa mais velha: " + nomes[pos]);
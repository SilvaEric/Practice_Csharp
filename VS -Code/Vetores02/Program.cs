using System.Security.AccessControl;

int n = int.Parse(Console.ReadLine());

string [] vet = Console.ReadLine().Split(' ');

int[] nums = new int[n];

int contP = 0;

for(int i = 0; i < n; i++){
    nums [i] = int.Parse(vet[i]);
    if(nums[i] % 2 == 0){
        contP ++;
    }
}

int[] numsP = new int[contP];

int cont = 0;

for( int i = 0 ; i<n ; i++){
    if(nums[i] % 2 == 0){
        numsP [cont] = nums[i];
        Console.Write(numsP[cont] + " ");
        cont++;
    }
}
Console.WriteLine();
Console.WriteLine(contP);





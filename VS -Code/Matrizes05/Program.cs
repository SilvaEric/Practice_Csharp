int [,] m , n, o;

string [] ent = Console.ReadLine().Split(' ');
int lines = int.Parse(ent[0]);
int coluns = int.Parse(ent[1]);

m = new int [lines, coluns];
n = new int [lines, coluns];
o = new int [lines, coluns];

for(int i = 0; i < lines; i++){
    string [] vet = Console.ReadLine().Split();
    for(int j = 0; j < coluns; j++){
        m [i,j] = int.Parse(vet[j]);
    }
}

for(int i = 0; i < lines; i++){
    string [] vet = Console.ReadLine().Split();
    for(int j = 0; j < coluns; j++){
        n [i,j] = int.Parse(vet[j]);
    }
}

for(int i = 0; i < lines; i++){
    for(int j = 0; j < coluns; j++){
        o[i,j] = m[i,j] + n[i,j];
        Console.Write(o[i,j] + " ");
    }
    Console.WriteLine();
}

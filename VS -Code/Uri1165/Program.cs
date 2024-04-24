int NumTest, i, j, Teste, ContDivs;

NumTest = int.Parse(Console.ReadLine());

for(i = 1; i <= NumTest; i++){
    ContDivs = 0;
    Teste = int.Parse(Console.ReadLine());
    for(j = Teste; j > 0; j --){
        if( Teste % j == 0){
            ContDivs += 1;
        }
    }
    if(ContDivs == 2){
        Console.WriteLine(Teste + " eh primo");
    }
    else{
        Console.WriteLine(Teste + " nao eh primo");
    }
}
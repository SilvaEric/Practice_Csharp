using System.Globalization;

int n = int.Parse(Console.ReadLine());

int homems = 0;
int mulheres = 0;
double menoralt = 0;
double maioralt = 0;
double media = 0;
double soma = 0;

for(int i = 0; i<n; i++){
    string [] a = Console.ReadLine().Split(' ');
    if(i == 0){
        menoralt = double.Parse(a[0], CultureInfo.InvariantCulture);
        maioralt = double.Parse(a[0], CultureInfo.InvariantCulture);
        if(a[1] == "F"){
            soma += double.Parse(a[0], CultureInfo.InvariantCulture);
            mulheres++;
        }
        else{
            homems ++;
        }
    }
    else{
        if(a[1] == "F"){
            mulheres++;
            soma += double.Parse(a[0], CultureInfo.InvariantCulture);
        }
        if(a[1] == "M"){
            homems++;
        }
        if(double.Parse(a[0], CultureInfo.InvariantCulture) > maioralt){
            maioralt = double.Parse(a[0], CultureInfo.InvariantCulture);
        }
        else if(double.Parse(a[0], CultureInfo.InvariantCulture) < menoralt){
            menoralt = double.Parse(a[0], CultureInfo.InvariantCulture);
        }
    }
}
media = soma / mulheres;
Console.WriteLine("Menor altura = " + menoralt.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Maior altura = " + maioralt.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Media das alturas das mulheres = "+ media.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("NUmero de homens = " + homems);
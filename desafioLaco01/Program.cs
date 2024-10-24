// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|               EMPRESAS               |
+--------------------------------------+
");

int homem = 0;
string respostaProduto;
int gostamF = 0;
int gostamM = 0;
int ngostamM = 0;
int ngostamF = 0;
int resultado = 0;
int gostamG = 0;
int naogostamG = 0;




for (var i = 1; i <= 10; i++)
{


    Console.WriteLine($"Qual o seu sexo? f/m");
    string sexo = Console.ReadLine();

    Console.WriteLine($"Você gosta do produto? s/m");
    respostaProduto = Console.ReadLine();

    if (sexo == "m")
    {
        homem++;
    }

    if (respostaProduto == "s")
    {
        gostamG++;
        if (sexo == "f")
        {
            gostamF++;
        }
        else
        {
            gostamM++;
        }
    }else{
        
        naogostamG++;
        if (sexo == "f")
        {
            ngostamF++;
        }
        else
        {
            ngostamM++;
        }

    }
}

resultado = (100 / homem) * ngostamM;

Console.WriteLine($"Pessoas que responderam sim: {gostamG}");
Console.WriteLine($"Pessoas que responderam não: {naogostamG}");
Console.WriteLine($"Mulheres que responderam sim: {gostamF}");
Console.WriteLine($"Percentual de homens que disseram não: {resultado}");
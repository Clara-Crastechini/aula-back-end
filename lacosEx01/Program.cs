// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");


Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qntEntrevistados = int.Parse(Console.ReadLine()!);


int homem = 0;
int mulher = 0;
string sexo;
string esporte;
int qntEsporte = 0;
int qntNaoEsporte = 0;

Console.WriteLine(homem);
Console.WriteLine(mulher);


for (int i = 1; i <= qntEntrevistados; i++)
{
    Console.WriteLine($"Qual o seu sexo? f/m");
    sexo = Console.ReadLine();

    
    if(sexo == "f"){
        mulher++;
    }else{
        homem++;
    }


    Console.WriteLine($"Você gosta de esporte?");
    esporte = Console.ReadLine();


    if(esporte == "sim"){
        qntEsporte++;
    }else {
        qntNaoEsporte++;
    }
}


float percentual = (100 / qntEntrevistados) * qntEsporte;


Console.WriteLine($"Quantidade de homem: {homem}");
Console.WriteLine($"Quantidade de mulher: {mulher}");
Console.WriteLine($"Quantidade de entrevistados: {qntEntrevistados}");
Console.WriteLine($"Quantidade de pessoas que gostam de esporte: {qntEsporte}");
Console.WriteLine($"Quantidade de pessoas que não gostam de esporte: {qntNaoEsporte}");
Console.WriteLine($"Percentual das pessoas que não gostam: {percentual}");






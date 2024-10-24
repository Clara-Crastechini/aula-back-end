// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|            INTERCALAÇÕES             |
+--------------------------------------+
");

// Faça um programa que carregue dois vetores de 10 elementos numéricos cada um e imprima a intercalação desses dois

int [] vetor1 ={1, 3, 5, 7, 9};
int [] vetor2 = {0, 2, 4, 6, 8};

for (var i = 0; i < vetor1.Length; i++)
{
    // vetor1++;
    Console.WriteLine(vetor1[i]);
    
    for (var a = 0; a < vetor2.Length; a++)
    {
        Console.WriteLine(vetor2[a]);
        // vetor2++;
    }
}
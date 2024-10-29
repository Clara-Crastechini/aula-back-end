// See https://aka.ms/new-console-template for more information

// Faça um programa que carregue 1 array tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.


Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|           PARES E IMPARES            |
+--------------------------------------+
");

int par = 0;
int impar = 0;
int[] numeros = new int[6];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        par++;
    }else{
        impar++;
    }
}

Console.WriteLine();


Console.WriteLine($"Numeros pares: {par} ");

for (var i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.Write($"{numeros[i]} ");
        
    }
}


Console.WriteLine();


Console.WriteLine($"Numeros impares: {impar}");

for (var i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 1)
    {
        Console.Write($"{numeros[i]} ");
        
    }
}




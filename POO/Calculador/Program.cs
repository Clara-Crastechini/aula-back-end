// See https://aka.ms/new-console-template for more information
using Calculador.Classes;
Console.Clear();
Console.WriteLine("Bem vinda a Calculadora");

Calculadora calculadora = new Calculadora ();

Console.WriteLine($"Digite o primeiro numero: ");
calculadora.numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero: ");
calculadora.numero2 = float.Parse(Console.ReadLine());

Console.Write($@" 
1- Somar
2- Subtrair
3- Multiplicar
4- Dividir 
Digite uma operação: ");
int operacao = int.Parse(Console.ReadLine());


if (operacao == 1)
{ 
    Console.Write("Resultado é: ");
    calculadora.Somar(0);
   
} else if (operacao == 2)
{
    Console.Write("Resultado é: ");
    calculadora.Subtrair(0);
} else if (operacao == 3)
{   
    Console.Write("Resultado é: ");
    calculadora.Multiplicar(0);
} else
{
    Console.Write("Resultado é: ");
    calculadora.Dividir(0);
};







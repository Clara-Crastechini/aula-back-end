// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|          CONTROLE DE MAÇAS           |
+--------------------------------------+
");

Console.WriteLine($"Digite a quantidade de maças: ");
int qntmacas = int.Parse(Console.ReadLine());

float resultado;

if (qntmacas < 12) {
    resultado = qntmacas * 0.30f;
    Console.WriteLine($"O valor total é de: {resultado}");
} else {
    resultado = qntmacas * 0.25f;
    Console.WriteLine($"O valor total é de: {resultado}");
}

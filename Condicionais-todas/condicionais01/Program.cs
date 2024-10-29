// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTROLE DE GASTOS           |
+--------------------------------------+
");


Console.WriteLine("Digite seu salario: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine("\n");

Console.WriteLine("Digite o total gasto: ");
float gastos = float.Parse(Console.ReadLine());

Console.WriteLine("\n");

if (gastos > salario){
    Console.WriteLine("Limite estourado.");
} else {
    Console.WriteLine("O valor está dentro do orçamento.");
}

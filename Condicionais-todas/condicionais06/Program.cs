// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTROLE DE ALUNOS           |
+--------------------------------------+
");

Console.WriteLine($"Informe sua porcentagem de frequência: ");
float frequencia = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe sua nota: ");
float nota = float.Parse(Console.ReadLine());


if (frequencia >= 75 && nota >= 7 ) {
    Console.WriteLine($"Aprovado");
} else if (nota >3 && nota <7 ) {
    Console.WriteLine($"Recuperação");
} else {
    Console.WriteLine($"Reprovado");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|          CONTROLE DE SENHA           |
+--------------------------------------+
");

Console.WriteLine($"Digite a senha: ");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234){
    Console.WriteLine($"Acesso permitido.");
} else {
    Console.WriteLine($"Acesso negado.");
}


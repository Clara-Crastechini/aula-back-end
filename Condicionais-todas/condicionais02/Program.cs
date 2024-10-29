// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|          CALCULO DE PONTOS           |
+--------------------------------------+
");


Console.WriteLine($"Quantos pontos o time 1 fez?");
int time1 = int.Parse(Console.ReadLine());


Console.WriteLine($"Quantos pontos o time 2 fez?");
int time2 = int.Parse(Console.ReadLine());

if (time1 > time2){
    Console.WriteLine("Time 1 venceu.");
} else if (time2 > time1) {
    Console.WriteLine("Time 2 venceu.");
} else {
    Console.WriteLine("Empate.");
}



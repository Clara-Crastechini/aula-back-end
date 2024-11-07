using RPG.Classes;
Console.Clear();


Console.WriteLine($@"Bem vindo ao RPG");
Console.WriteLine();

Personagens personagem = new Personagens();

Console.Write($"Digite o nome do seu personagem: ");
personagem.Nome = Console.ReadLine();    

Console.Write($"Digite a idade do {personagem.Nome}: ");
personagem.Idade = int.Parse(Console.ReadLine());

Console.Write($"Digite o nome da armadura ultilizada: ");
personagem.Armadura = Console.ReadLine();  

Console.Write($"Digite o nome da IA utilizada: ");
personagem.IA = Console.ReadLine();  

Console.Clear();

Console.WriteLine($"NOME: {personagem.Nome}");
Console.WriteLine($"IDADE: {personagem.Idade}");
Console.WriteLine($"ARMADURA: {personagem.Armadura}");
Console.WriteLine($"IA: {personagem.IA}");
Console.WriteLine();




personagem.Atacar("");
Console.WriteLine($"O personagem {personagem.Nome} atacou.");
Console.WriteLine();


personagem.Defender("");
Console.WriteLine($"O personagem {personagem.Nome} defendeu.");
Console.WriteLine();


personagem.Restaurar("");
Console.WriteLine($"O personagem {personagem.Nome} restaurou a armadura.");
Console.WriteLine();






using System.Net.Http.Headers;
using ClassesObjetos.Classes;

Animal cachorro = new Animal();

cachorro.nome = "Lolla";
cachorro.raca = "Vira-Lata";
cachorro.cor = "Branca e Marrom";
cachorro.idade = 3;

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"Raça da {cachorro.nome}: {cachorro.raca}");
Console.WriteLine($"Cor da {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Idade da {cachorro.nome}: {cachorro.idade}");


 Animal gato = new Animal();

 gato.nome = "Romeu";
 gato.raca = "vira-lata";
 gato.cor = "cor";
 gato.idade = 8;

 Console.WriteLine($"Nome da {gato.nome}: {gato.nome}");
 Console.WriteLine($"Raca da {gato.nome}: {gato.raca}");
 Console.WriteLine($"Cor da {gato.nome}: {gato.cor}");
 Console.WriteLine($"Idade da {gato.nome}: {gato.idade}");

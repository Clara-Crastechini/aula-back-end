using System.Net.Http.Headers;
using ClassesObjetos.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao programa ZooSharp");


Animal cachorro = new Animal();

cachorro.nome = "Lolla";
cachorro.raca = "Vira-Lata";
cachorro.cor = "Branca e Marrom";
cachorro.idade = 3;
// cachorro.FazerBarulho = "au au";



Console.WriteLine();



 Animal gato = new Animal();

 gato.nome = "Romeu";
 gato.raca = "vira-lata";
 gato.cor = "cor";
 gato.idade = 8;
//  gato.FazerBarulho = "miau miau";


//  Console.WriteLine($"Nome do gato: {gato.nome}");
//  Console.WriteLine($"Raca do {gato.nome}: {gato.raca}");
//  Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
//  Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");
//  Console.WriteLine($"Barulho do {gato.nome}: {gato.FazerBarulho}");
//  Console.WriteLine();


 Animal peixe = new Animal();

 peixe.nome = "Tico";
 peixe.raca = "Beta";
 peixe.cor = "azul";
 peixe.idade = 1;
//  peixe.FazerBarulho = "....";

//  Console.WriteLine($"Nome do peixinho: {peixe.nome}");
//  Console.WriteLine($"Raca do {peixe.nome}: {peixe.raca}");
//  Console.WriteLine($"Cor do {peixe.nome}: {peixe.cor}");
//  Console.WriteLine($"Idade do {peixe.nome}: {peixe.idade}");
//  Console.WriteLine($"Barulho do {peixe.nome}: {peixe.FazerBarulho}");


cachorro.FazerBarulho("auau");
Console.WriteLine($"Idade da {cachorro.nome} é {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade da {cachorro.nome} é {cachorro.idade}");
Console.WriteLine();


gato.FazerBarulho("miau");
Console.WriteLine($"Idade do {gato.nome} é {gato.idade}");
gato.Envelhecer();
Console.WriteLine($"Nova idade do {gato.nome} é {gato.idade}");
Console.WriteLine();


peixe.FazerBarulho("....");
Console.WriteLine($"Idade do {peixe.nome} é {peixe.idade}");
peixe.Envelhecer();
Console.WriteLine($"Nova idade do {peixe.nome} é {peixe.idade}");
Console.WriteLine();

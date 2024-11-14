// See https://aka.ms/new-console-template for more information
string[] frutas ={"Melancia", "Carambola", "Marácuja", "Morango", "Limão", "Jabuticaba", "Abacata", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pêssego", "Banana"};

Console.WriteLine($"Sua sacola contém {frutas.Length} frutas!");

foreach (string f in frutas)
{
    Console.Write($"{f}, ");
}

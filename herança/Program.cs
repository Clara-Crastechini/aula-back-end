using System;

// Classe base (superclasse)
class Animal
{
    // Propriedade/atributo para armazenar o nome do animal
    public string Nome { get; set; }

    // Método/funcao = acao do animal
    public virtual string FazerSom()
    {
        return "Som de animal";
    }
}

// Classe Cachorro que herda de Animal
class Cachorro : Animal
{
    public Cachorro()
    {
        Nome = "Cachorro";
    }

    // Sobrescrevendo o método para retornar o som do cachorro
    public override string FazerSom()
    {
        return "Au Au";
    }
}

// Classe Gato que herda de Animal
class Gato : Animal
{
    public Gato()
    {
        Nome = "Gato";
    }

    // Sobrescrevendo o método para retornar o som do gato
    public override string FazerSom()
    {
        return "Miau";
    }
}

// Classe principal onde o programa começa
class Program
{
    static void Main()
    {
        // Criando um cachorro e um gato(objetos)
        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();
        Animal edu = new Animal();
        edu.Nome = "Edu animal";

        // Mostrando o nome e o som de cada animal
        Console.WriteLine($"{cachorro.Nome} faz: {cachorro.FazerSom()}");
        Console.WriteLine($"{gato.Nome} faz: {gato.FazerSom()}");
        Console.WriteLine($"{edu.Nome} faz: {edu.FazerSom()}");

    }
}

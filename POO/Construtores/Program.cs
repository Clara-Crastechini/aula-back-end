using System.Runtime.InteropServices;
using Construtores.Classes;

Console.Clear();

// Veiculo carro1 = new Veiculo("Ford", "KA", 2000, "Vermelho");

// Veiculo carro2 = new Veiculo("BMW", "M3", 2021, "Preta");

// carro1.ExibirDados();
// carro2.ExibirDados();


// Aluno aluno1 = new Aluno("Clara", 16, "dev");
// aluno1.ExibirDados();



List<Jogo> EstoqueJogos = new List<Jogo>();
// Jogo jogo1 = new Jogo("Minecraft", 2010, 40, "Aventura");
// Jogo jogo2 = new Jogo("Call Of Duty", 2003, 60, "Ação");
// Jogo jogo3 = new Jogo("Call Of Duty - Shadow of the Colossus", 2005, 62, "Ação");
// Jogo jogo4 = new Jogo("GTA", 2010, 110, "Aventura");

// EstoqueJogos.Add(jogo1);
// EstoqueJogos.Add(jogo2);
// EstoqueJogos.Add(jogo3);
// EstoqueJogos.Add(jogo4);

// foreach (var jogo in EstoqueJogos)
// {
    // Console.WriteLine($"Jogo: {jogo.nome}");
    // Console.WriteLine($"Lançamento: {jogo.lancamento}");
    // Console.WriteLine($"Valor: {jogo.valor}");
    // Console.WriteLine($"Gênero: {jogo.genero}");
    // Console.WriteLine();
    
//     jogo.ExibirDados();
//     Console.WriteLine();
    
// }
int opcao;
int JogosListas;
do
{   
    Console.WriteLine(@$"
    Menu de opções:
    1) Cadastrar Jogo
    2) Listar Jogos 
    0) Sair");
    Console.Write($"R:");
    opcao = int.Parse(Console.ReadLine()!);
    

    if (opcao == 1)
    {
        Console.Write($"Nome: ");
        string nome = Console.ReadLine();
        Console.Write($"Lançamento: ");
        int lancamento = int.Parse(Console.ReadLine()!);
        Console.Write("Valor: ");
        float valor = float.Parse(Console.ReadLine()!);
        Console.Write($"Gênero: ");
        string genero = Console.ReadLine();
        ;
    }
    else if (opcao == 2){

    }
} while (opcao != 0 );
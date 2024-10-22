// variáveis e tipos de dados
// estruturas condicionais 
// laços de repetição
// arrays


Console.WriteLine(@"

+-------------------------------------+
|            Olá, Bom dia             |
+-------------------------------------+
|           SEJA BEM-VINDO            |
+-------------------------------------+
");

Console.WriteLine($"Olá, digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome}, digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

//int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu email: ");
string email = Console.ReadLine();

Console.WriteLine($"Digite seu telefone: ");
int telefone = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu CPF: ");
string cpf = Console.ReadLine();


Console.WriteLine($"Digite seu endereço: ");
string endereço = Console.ReadLine();


//Console.WriteLine($"Digite sua idade: ");
//int idade = int.Parse(Console.ReadLine());


Console.WriteLine($"Qual o seu estado civil?");
string EstadoCivil = Console.ReadLine();

Console.WriteLine($"Em que ano você nasceu?");
int AnoNascimento = int.Parse(Console.ReadLine());
int AnoAtual = DateTime.Now.Year;
int idade = AnoAtual - AnoNascimento;






Console.WriteLine($" Olá: {nome} {sobrenome}, \n Data de nascimentos: {AnoNascimento},  \n Email: {email}, \n Telefone: {telefone}, \n CPF: {cpf}, \n Endereço: {endereço}, \n Idade:  {idade}, \n Estado civil: {EstadoCivil} \n");


Console.WriteLine($" {nome}, cadastro concluido!");

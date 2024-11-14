// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using PilaresPOO.Classes;
using PilaresPOO.Classes.Aprendizagem;

// Aluno clara = new Aluno();
// clara.nome = "Clara";

// // Console.WriteLine($"{clara.nome} Nasceu com {clara.idade} anos");

// Professor sam = new Professor(123321);
// sam.nome = "Samanta";
// sam.idade = 22;

// Aluno richardLima = new Aluno();
// richardLima.nome = "Richard Lima";
// richardLima.idade = 17;
// richardLima.cpf = 123654;
// richardLima.peso = 76f;
// richardLima.altura = 1.78f;
// richardLima.matricula = 123456;
// richardLima.curso = "dev";
// richardLima.media = 7.9f;

// Console.WriteLine($"Curso: {richardLima.curso}");
// Console.WriteLine($"Professor(a): {sam.nome}");
// Console.WriteLine($"Identificação do professor: {sam.NIF}");

// Console.WriteLine($"Aluno: {richardLima.nome}");
// Console.WriteLine($"Idade do aluno: {richardLima.idade}");
// Console.WriteLine($"CPF: {richardLima.cpf}");
// Console.WriteLine($"Peso: {richardLima.peso}");
// Console.WriteLine($"Altura: {richardLima.altura}");
// Console.WriteLine($"Matricula: {richardLima.matricula}");
// Console.WriteLine($"Curso: {richardLima.curso}");
// Console.WriteLine($"Média: {richardLima.media}");


Console.Clear();

Carro carro1 = new Carro();
carro1.marca = "Chevrolet";
carro1.modelo = "Impala 67";
carro1.cor = "Preto";
carro1.potencia = 270f;
carro1.qtdPassageiros = 4;
carro1.qntPorta = 4;



Aviao aviao1 = new Aviao();
aviao1.marca = "AirFrance";
aviao1.modelo = "Boeing 777";
aviao1.cor = "Branco";
aviao1.potencia = 660f;
aviao1.qtdPassageiros = 410;
aviao1.qtdPorta = 6;



Moto moto1 = new Moto();
moto1.marca = "Honda";
moto1.modelo = "Hornet";
moto1.cor = "Vermelha";
moto1.potencia = 96.5f;
moto1.qtdPassageiros = 2;
moto1.qntRodas = 2;


Console.WriteLine(@$"       Carro
Marca: {carro1.marca}
Modelo: {carro1.modelo}
Cor: {carro1.cor} 
Potência: {carro1.potencia}
Quantidade de Passageiros: {carro1.qtdPassageiros}
Quantidade de Portas: {carro1.qntPorta}
Ligando: {carro1.Ligar()}
Buzinando: {carro1.Buzinar()}
Desligando: {carro1.Desligar()}");

Console.WriteLine();


Console.WriteLine(@$"       Avião
Marca: {aviao1.marca}
Modelo: {aviao1.modelo} 
Cor: {aviao1.cor} 
Potência: {aviao1.potencia}
Quantidade de Passageiros: {aviao1.qtdPassageiros}
Quantidade de Portas: {aviao1.qtdPorta}
Ligando: {aviao1.Ligar()}
Buzinando: {aviao1.Buzinar()}
Desligando: {aviao1.Desligar()}
");


Console.WriteLine();

Console.WriteLine(@$"       Moto
Marca: {moto1.marca}
Modelo: {moto1.modelo} 
Cor: {moto1.cor} 
Potência: {moto1.potencia}
Quantidade de Passageiros: {moto1.qtdPassageiros}
Quantidade de Roda: {moto1.qntRodas}
Ligando: {moto1.Ligar()}
Buzinando: {moto1.Buzinar()}
Desligando: {moto1.Desligar()}
");



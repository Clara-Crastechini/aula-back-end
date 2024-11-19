using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctCras = new ContaCorrente();
ctCras.Titular = "Clara Sousa Crastechini";
ctCras.Depositar(1200f);


Console.WriteLine($"Titular da conta: {ctCras.Titular}");
Console.WriteLine($"Saldo da conta: {ctCras.getSaldo()}");

float valorSacado = ctCras.Sacar(1000f);
Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Saldo da conta: {ctCras.getSaldo()}");



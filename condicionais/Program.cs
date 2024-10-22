// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+-------------------------------------+
|           SEJA BEM-VINDO            | 
|                  AO                 |
|          PROGRAMA PRODUTO           |
+-------------------------------------+
");


float precoProduto = 200;
float minhaCarteira = 350;

if(minhaCarteira >= precoProduto) {

    Console.WriteLine("Sim, é possível comprar!");
} else {
    Console.WriteLine("Não, não é possível comprar.");
}


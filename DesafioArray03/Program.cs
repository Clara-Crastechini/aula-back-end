// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|             TEMPERATURA              |
+--------------------------------------+
");


// [ ] DesafioArray03: Faça um programa que receba a temperatura média de cada mês do ano e armazene essas temperaturas em um vetor. Calcule e imprima a maior e a menor temperatura do ano.

float[] temperaturas = new float[12];

        
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Digite a temperatura média do mês {i + 1}: ");
            temperaturas[i] = int.Parse(Console.ReadLine());
        }

        float menorTemperatura = temperaturas[0];
        float maiorTemperatura = temperaturas[0];
     

        for (int i = 1; i < 12; i++)
        {
            if (temperaturas[i] > maiorTemperatura)
                maiorTemperatura = temperaturas[i];
            if (temperaturas[i] < menorTemperatura)
                menorTemperatura = temperaturas[i];
        }

        Console.WriteLine();
        
        
        Console.WriteLine($"A maior temperatura do ano foi: {maiorTemperatura}°C");
        Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}°C");
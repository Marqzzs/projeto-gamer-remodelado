using Classes_estaticas;

ConsoleKeyInfo opcao;

do
{

    Console.WriteLine(@$"
        Convert Menu

'1' para Reais em Dolar
'2' para Dolar em Reais

'3' para sair
");
    opcao = Console.ReadKey(true);

    switch (opcao.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine($"Digite o Valor a ser Convertido:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            Console.WriteLine($"Valor Convertido: {Conversor.ReaisParaDolar(Conversor.Valor)}");

            break;

        case ConsoleKey.D2:
            Console.WriteLine($"Digite o Valor a ser Convertido:");
            Conversor.Valor = float.Parse(Console.ReadLine());
            Console.WriteLine($"Valor Convertido: {Conversor.DolarParaReais(Conversor.Valor)}");
            break;
        case ConsoleKey.D3:
        Environment.Exit(3);
        break;
        default:
        Console.WriteLine($"Opção não Disponivel");
            break;
    }
} while (true);






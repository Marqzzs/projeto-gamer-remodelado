using exercicio_fixação;

List<Carros> carros = new List<Carros>();

ConsoleKeyInfo opcao;

do
{
    Console.WriteLine(@$"
    |------------------------------------
    |             MENU                  | 
    |                                   | 
    | '1' Para cadastro de carros       | 
    | '2' Para exibição dos cadastrados | 
    | '3' Para sair do programa         | 
    -------------------------------------
    ");
    opcao = Console.ReadKey(true);

    switch (opcao.Key)
    {
        case ConsoleKey.D1:

            for (int i = 0; i < 2; i++)
            {
                Carros carro = new Carros();

                Console.WriteLine("Digite a marca do carro:");
                carro.Marca = Console.ReadLine();

                Console.WriteLine("Digite a cor do carro:");
                carro.Cor = Console.ReadLine();

                carros.Add(carro);
            }
            break;
        case ConsoleKey.D2:
        foreach (var item in carros)
        {
            Console.WriteLine($"Marca: {item.Marca}");
            Console.WriteLine($"Cor: {item.Cor}");
            Console.WriteLine($"-----------------------\n");
        }
            break;
        case ConsoleKey.D3:
        Console.WriteLine($"Saindo...");
            Environment.Exit(3);
            break;
        default:
            Console.WriteLine($"Opção não disponivel");
            
            break;
    }
} while (true);

using POO;

Personagem tony = new Personagem();
Console.WriteLine($"Digite o nome do personagem:");
tony.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do personagem:");
tony.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a armadura do personagem:");
tony.armadura = Console.ReadLine();

tony.IA = Console.ReadLine();

Console.WriteLine(@$"
{tony.nome}
{tony.idade}
{tony.armadura}
{tony.IA}
");

tony.Atacar();
tony.Defender();
tony.RestaurarArmadura();

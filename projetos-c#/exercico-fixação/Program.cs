using exercico_fixação.Controller;
using exercico_fixação.Model;
using exercico_fixação.View;

Evento e = new Evento();

ConsoleKeyInfo opcao;

EventoController eventoController = new EventoController();
EventoView eventoView = new EventoView();

do
{
    Console.WriteLine(@$"
---------------------------
        Menu de Eventos
---------------------------
[1] - Para Cadastrar evento

[2] - Para listar eventos
---------------------------
[3] - Para encerrar
");

    opcao = Console.ReadKey(true);

    switch (opcao.Key)
    {
        case ConsoleKey.D1:
            eventoController.CadastrarEvento();
            break;

        case ConsoleKey.D2:
            eventoController.ListarEvento();
            break;

        case ConsoleKey.D3:
            Environment.Exit(3);
            break;
        default:
            break;
    }
} while (true);

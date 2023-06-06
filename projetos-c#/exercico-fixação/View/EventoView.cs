using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercico_fixação.Controller;
using exercico_fixação.Model;

namespace exercico_fixação.View
{
    public class EventoView
    {

        public void Listar(List<Evento> eventos)
        {
            foreach (var item in eventos)
            {
                Console.WriteLine(@$"
---------------------------------
Nome: {item.Nome}
Descrição: {item.Descricao}Data: 
{item.Data}
----------------------------------
                ");
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome do Evento:");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Digite a descrição");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
        }
    }
}
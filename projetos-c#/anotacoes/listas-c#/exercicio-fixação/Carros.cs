using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixação
{
    public class Carros
    {
        public string Marca { get; set; }
        public string Cor { get; set; }

        public Carros()
        {
            
        }
        public Carros(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;

            Console.WriteLine($"Digite a marca do carro:");
            marca = Console.ReadLine();
            
            Console.WriteLine($"Digite a cor do veiculo:");
            cor = Console.ReadLine();
        }
    }
}
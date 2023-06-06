using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }
        
        //lista onde vamos armazenar os objetos e manipular
        List<Produto> carrinho = new List<Produto>();

        //implementar a logica para cada metodo
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }
        public void Listar()
        {
            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Codigo: {p.Codigo} Nome: {p.Nome} Preço: {p.Preco}\n");
                }
            }
            else
            {
                Console.WriteLine($"Carrinho vazio!");
                
            }
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }


        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void ValorTotal()
        {
            Valor = 0;
            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"Valor Total: {Valor:C}\n");  
            }
            else
            {
                Console.WriteLine($"O carrinho esta vazio!\n");                
            }
        }
    }
}
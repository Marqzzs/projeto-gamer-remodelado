using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    //interface para a class carrinho
    public interface ICarrinho
    {
        //definir quais os metodos deverao ser implementador na classe que herdara desta inteface
        //CRUD: create; read; update; delete

        //creat
        void Adicionar(Produto _produto);

        //read
        void Listar();

        //update
        void Atualizar(int _codigo, Produto _produto);

        //delete
        void Remover(Produto _produto);
    }
}
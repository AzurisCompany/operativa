using System;
using System.Collections.Generic;
using System.Text;
using DatabaseLib.Model;

namespace DatabaseLib.IServices
{
    public interface IDatabase
    {
        void Inserir(Produto p);
        List<Produto> Listar();
        void Deletar(int Id);
        void Update(Produto p);
        Produto Carregar(int Id);
    }
}

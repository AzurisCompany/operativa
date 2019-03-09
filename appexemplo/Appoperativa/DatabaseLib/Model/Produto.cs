using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DatabaseLib.Model
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Localizacao { get; set; }
        public float Preco { get; set; }
        public string CodigodeBarra { get; set; }

        public static List<Produto> Listar()
        {
            var lista = new List<Produto>();
            lista.Add(new Produto() { Id = 1, Nome = "Goiabada"});
            lista.Add(new Produto() { Id = 2, Nome = "pao" });
            lista.Add(new Produto() { Id = 3, Nome = "queijo" });
            lista.Add(new Produto() { Id = 4, Nome = "presunto" });
            lista.Add(new Produto() { Id = 5, Nome = "leite" });
            return lista;
        }

    }
}

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
    

    }
}

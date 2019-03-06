using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace DatabaseLibORM.Model
{
    [Table("produto")]
    public class ProdutoORM
    {
        public string Nome { get; set; }

        [PrimaryKey]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Descricao { get; set; }

        public int Quantidade { get; set; }
        public string Localizacao { get; set; }
        public float Preco { get; set; }
        public string CodigodeBarra { get; set; }
    }
}

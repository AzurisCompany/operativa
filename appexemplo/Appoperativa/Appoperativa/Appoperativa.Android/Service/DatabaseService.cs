using System;
using System.Collections.Generic;
using System.IO;
using DatabaseLib.IServices;
using DatabaseLib.Model;
using Mono.Data.Sqlite;

namespace Appoperativa.Droid.Service
{
    public class DatabaseService : IDatabase
    {
        public static SqliteConnection connection; 

        public Produto Carregar(int Id)
        {
            throw new NotImplementedException();
        }

        public void CriarBanco()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "adodemo.db3");

            bool exists = File.Exists(dbPath);

            if (!exists)
            {
                // Need to create the database and seed it with some data.
                Mono.Data.Sqlite.SqliteConnection.CreateFile(dbPath);
                connection = new SqliteConnection("Data Source=" + dbPath);

                connection.Open();

                string sql = "CREATE TABLE [Produto] (id ntext, " +
                             "nome ntext, descricao ntext, quantidade integer, " +
                             "preco float, codigodebarra ntext, localizacao ntext" +
                             " );";
                var c = connection.CreateCommand();
                c.CommandText = sql;
                var i = c.ExecuteNonQuery();
                connection.Close();
            }
            
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Produto p)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Personal), "adodemo.db3");

            bool exists = File.Exists(dbPath);
            // Criara a conexao

            if (exists)
            {
                connection = new SqliteConnection("Data Source=" + dbPath);
                // Abriar a conexao
                connection.Open();
            } 
                // criar o comando SQL
                string sql = "insert into Produto (id, nome, descricao, localizacao, quantidade, preco, codigodebarras) values( "
                + "'" + p.Id + "'" + ","
                + "'" + p.Nome + "'" + ","
                + "'" + p.Descricao + "'" + ","
                + "'" + p.Localizacao + "'" + "," +
                + p.Quantidade + ","
                + p.Preco + ","
                + "'" + p.CodigodeBarra + "'" + 
            ")";


            // Execuar o comando SQL
            var c = connection.CreateCommand();
            c.CommandText = sql;
            var i = c.ExecuteNonQuery();

            // Fechar a conexao com o banco 
            connection.Close();

        }

        public List<Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public void Update(Produto p)
        {
            throw new NotImplementedException();
        }
    }
}
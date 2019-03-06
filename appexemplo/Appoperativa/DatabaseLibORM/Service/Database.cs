using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DatabaseLibORM.Model;
using SQLite;

namespace DatabaseLibORM.Service
{
    public class DatabaseOrm
    {

        public void CriarBanco()
        {
            var db = SqLiteConnectionPath();
            db.CreateTable<ProdutoORM>();

        }

        public void Inserir(ProdutoORM p)
        {
            var db = SqLiteConnectionPath();
            db.Insert(p);
        }

        private static SQLiteConnection SqLiteConnectionPath()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            return db;
        }
    }
}

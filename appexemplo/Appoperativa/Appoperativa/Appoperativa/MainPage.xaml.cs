using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib.IServices;
using DatabaseLib.Model;
using DatabaseLibORM.Model;
using WebServerLib;
using Xamarin.Forms;

namespace Appoperativa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ProdutoWS pws = new ProdutoWS();
           // listaprodutos.ItemsSource = pws.Listar();
        }

        private void BntCadastro_OnClicked(object sender, EventArgs e)
        {
           Produto p = new Produto();
            p.Id = Convert.ToInt32( eId.Text);
            p.Descricao = eDescricao.Text;
            p.Nome = eNome.Text;

            var db = DependencyService.Get<IDatabase>();
            db.Inserir(p);


            ProdutoORM pORM = new ProdutoORM();
            pORM.Id = Convert.ToInt32(eId.Text);
            pORM.Descricao = eDescricao.Text;
            pORM.Nome = eNome.Text;

            var dbORM = new DatabaseLibORM.Service.DatabaseOrm();
            dbORM.Inserir(pORM);



        }
    }
}

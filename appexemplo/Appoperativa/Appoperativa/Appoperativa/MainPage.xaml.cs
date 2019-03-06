using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib.IServices;
using DatabaseLib.Model;
using Xamarin.Forms;

namespace Appoperativa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BntCadastro_OnClicked(object sender, EventArgs e)
        {
           Produto p = new Produto();
            p.Id = eId.Text;
            p.Descricao = eDescricao.Text;
            p.Nome = eNome.Text;

            var db = DependencyService.Get<IDatabase>();
            db.Inserir(p);

        }
    }
}

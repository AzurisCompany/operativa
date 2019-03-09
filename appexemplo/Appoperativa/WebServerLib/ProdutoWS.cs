using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib.Model;
using Newtonsoft.Json;

namespace WebServerLib
{
    public class ProdutoWS
    {
        public async Task<List<Produto>> Listar()
        {
            // Acesso via htp client
            string url = null,JSON = "";
            HttpClient ht = new HttpClient();
            HttpResponseMessage resposta = await ht.GetAsync(url);
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = await resposta.Content.ReadAsStringAsync();
                if (resultado != null){
                    JSON = resultado;
                }
            }
            // vai recebe um json
            // vai json -> lista de produtos
            var lista = JsonConvert.DeserializeObject<List<Produto>>(JSON);
            // retornar a lista de produtos
            return lista;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseLib.Model;
using WebServerLib;
using Xunit;

namespace XUnitTestWebService
{
    public class UnitTest1
    {
        [Fact]
        public void TestListarProdutos()
        {
            //httpcliente
            ProdutoWS pws = new ProdutoWS();

           Task<List<Produto>> result = pws.Listar();

            Assert.Equal( 6 , result.Result.Count );




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication4
{
    /// <summary>
    /// Testando uma aplicação webservic    
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class MeuServico : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public string RetornaParametro(string parametro)
        {
            return parametro + " = Retorno";
        }

        [WebMethod]
        public Carro RetornaCarro()
        {
            return new Carro() { Nome = "Uno", Ano = 2010, Marca = new Marca() {Nome = "Fiat" } };
        }
    }

    public class Carro
    {
        public string Nome { get; set; }
        public Marca Marca { get; set; }

        public int Ano { get; set; }
    }

    public class Marca
    {
        public string Nome { get; set; }
    }
}

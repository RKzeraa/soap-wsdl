using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Services;

namespace soap_wsdl
{
    /// <summary>
    /// Descrição resumida de servico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class servico : System.Web.Services.WebService
    {

        [WebMethod]
        public string CriarSenha()
        {
            string caraC =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ".ToLower() +
                "0123456789" + "%$#@!";

            int qtd = 8;

            Random sort = new Random();
            int numSort = 0;
            StringBuilder pass = new StringBuilder();
            

            for(int i = 0; i < qtd; i++)
            {
                numSort = sort.Next(0, caraC.Length - 1);
                pass.Append(caraC[numSort]);
            }


            return ""+pass;
        }
    }
}

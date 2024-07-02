using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace thesisManagementPanel
{
    public partial class Senha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MudarSenha ms = new MudarSenha();
            ms.senhaantiga = senhaatual.Value;
            ms.senhanova = novasenha.Value;
            ms.senhanova2 = novasenha1.Value;
            ms.usuario = Session["usr"].ToString();
            ms.trocapass();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Banco b = new Banco();
            SqlConnection conn = b.abrirconexao();
            string chkadm = "select admin from usuario where login ='" + Session["usr"].ToString() + "'";
            SqlCommand trueadm = new SqlCommand(chkadm, conn);
            string resultado = trueadm.ExecuteScalar().ToString();
            if (resultado == 1.ToString())
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("PainelPrincipal.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pesquisa.aspx");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contato.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sobre.aspx");
        }
    }
}
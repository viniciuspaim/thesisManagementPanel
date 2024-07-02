using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace thesisManagementPanel
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Banco b = new Banco();
            SqlConnection conn = b.abrirconexao();
            string chkadm = "select admin from usuario where login ='" + Session["usr"].ToString() + "'";
            SqlCommand trueadm = new SqlCommand(chkadm, conn);
            string resultado = trueadm.ExecuteScalar().ToString();
            if (resultado == 1.ToString())
            {
                Response.Write("<script language=javascript>alert('Seja bem vindo "+Session["usr"].ToString()+"');</script>");
            }
            else
            {
                Response.Redirect("PainelPrincipal.aspx");
            }
            Label1.Text = "Usuário: "+ Session["usr"].ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroGestor.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pesquisa.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("Senha.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace thesisManagementPanel
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
     
        protected void Button1_Click(object sender, EventArgs e)
        {
          
             string usuario = username.Value;
          

            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password.Value));

            byte[] result = md5.Hash;

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }

            string senha = stringBuilder.ToString();


            Banco b = new Banco();
            SqlConnection conn = b.abrirconexao();
            string chkusuario = "select count(*) from usuario where login ='" + usuario + "'";
            SqlCommand com = new SqlCommand(chkusuario, conn);
            int cont = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();

            if (cont == 1)
            {
                SqlConnection con = b.abrirconexao();
                string chkPassQuery = "select senha from usuario where login ='" + usuario + "'";
                SqlCommand cnpwd = new SqlCommand(chkPassQuery, con);
                string pass = cnpwd.ExecuteScalar().ToString();
                if (pass == senha)
                {
                    string chkid = "select login from usuario where login ='" + usuario + "'";
                    SqlCommand id = new SqlCommand(chkid, con);
                    Session["usr"] = id.ExecuteScalar().ToString();
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('A senha digitada não está correta!');</script>");
                }
            }
            else
            {
                Response.Write("<script language=javascript>alert('O usuário digitado não está correto ou não existe!');</script>");
            }
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
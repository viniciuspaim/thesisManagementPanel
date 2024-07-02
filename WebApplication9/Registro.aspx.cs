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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Banco b = new Banco();
            SqlConnection conn = b.abrirconexao();
            string chkusuario = "select count(*) from usuario where email ='" + email.Value + "' and " + "cpf ='" + cpf.Value + "'";
            SqlCommand com = new SqlCommand(chkusuario, conn);
            int cont = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();

            if (cont == 0)
            {
                Usuario r = new Usuario();
                r.nome = nome.Value;
                r.login = username.Value;

                MD5 md5 = new MD5CryptoServiceProvider();

                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password.Value));

                byte[] result = md5.Hash;

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    stringBuilder.Append(result[i].ToString("x2"));
                }

                r.senha = stringBuilder.ToString();
                r.email = email.Value;
                r.celular = celular.Value;
                r.cpf = cpf.Value;
                bool ok = r.cadastrarUsuario();
                if (ok == true)
                {
                    Response.Write("<script language=javascript>alert('Registrado!');</script>");
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Write("<script language=javascript>alert('Email e Cpf já constam no sistema!');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
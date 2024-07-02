using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace thesisManagementPanel
{
    public partial class CadastroGestor : System.Web.UI.Page
    {       

        protected void Page_Load(object sender, EventArgs e)
        {
            Banco b = new Banco();
            SqlConnection cn;
            cn = b.abrirconexao();

            try
            {
                    string sql = ("select idUsuario, nome from usuario");
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DropDownList1.DataSource = dt;
                    DropDownList1.DataValueField = "idUsuario";
                    DropDownList1.DataTextField = "nome";
                    DropDownList1.DataBind();


                    string sql1 = ("select idCurso, nome from curso");
                    SqlCommand cmd1 = new SqlCommand(sql1, cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    DropDownList2.DataSource = dt1;
                    DropDownList2.DataValueField = "idCurso";
                    DropDownList2.DataTextField = "nome";
                    DropDownList2.DataBind();

            }
            catch (Exception ex)
            {
                throw ex;                
            }
            finally
            {
                b.fecharConexao(cn);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Curso c = new Curso();
            c.gestorID = int.Parse(DropDownList1.SelectedValue);
            c.cursoID = int.Parse(DropDownList2.SelectedValue);
            c.Inserir();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {

        }
        protected void Button5_Click(object sender, EventArgs e)
        {

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admins.aspx");   
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Senha.aspx");   
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
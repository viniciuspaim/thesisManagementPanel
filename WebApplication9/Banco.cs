using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thesisManagementPanel
{
    public class Banco
    {
        public SqlConnection abrirconexao()
        {
            string con = @"Data Source=LAB01-M11\SQLEXPRESS;Database=GB;Integrated Security=True;";
            SqlConnection cn = new SqlConnection(con);


            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void fecharConexao(SqlConnection cn)
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public DataTable ExecutarConsulta(string sql)
        {
            SqlConnection cn = abrirconexao();
            try
            {
                SqlCommand Command = new SqlCommand(sql, cn);
                Command.ExecuteNonQuery();
                SqlDataAdapter DA = new SqlDataAdapter(Command);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                return DT;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                fecharConexao(cn);
            }
        }
    }
}
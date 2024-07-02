using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace thesisManagementPanel
{
    public class CadAdm
    {
        public int idUsuario { get; set; }
        private int adm = 1;


        public bool Inserir()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = "update usuario set admin = @adm WHERE idUsuario = @idUsuario";
            c1.Parameters.Add("@adm", SqlDbType.Int);
            c1.Parameters.Add("@idUsuario", SqlDbType.Int);
            c1.Parameters[0].Value = adm;
            c1.Parameters[1].Value = idUsuario;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception e)
            {
                t1.Rollback();
                return false;
            }
            finally
            {

            }
        }

        public bool Remover()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = "update usuario set admin = NULL WHERE idUsuario = @idUsuario";
            c1.Parameters.Add("@idUsuario", SqlDbType.Int);
            c1.Parameters[0].Value = idUsuario;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception e)
            {
                t1.Rollback();
                return false;
            }
            finally
            {

            }
        }
    }
}
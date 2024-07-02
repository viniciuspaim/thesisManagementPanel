using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace thesisManagementPanel
{
    public class Curso
    {
        public int gestorID { get; set; }
        public int cursoID { get; set; }

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
            c1.CommandText = "update curso set gestor_idUsuario = @gestorID WHERE idCurso = @cursoID";
            c1.Parameters.Add("@gestorID", SqlDbType.Int);
            c1.Parameters.Add("@cursoID", SqlDbType.Int);
            c1.Parameters[0].Value = gestorID;
            c1.Parameters[1].Value = cursoID;

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
            //public bool cadastrarCurso()
            //{

            //}

            //public bool editarCurso()
            //{ }

            //public bool excluirCurso()
            //{ }

            //public bool consultar()
            //{ }
        }
    }
}
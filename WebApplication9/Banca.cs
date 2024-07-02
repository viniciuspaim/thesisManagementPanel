using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace thesisManagementPanel
{
    public class Banca
    {
        // Get/Set para inserções
        public string titulo { get; set; }
        public DateTime data_banca { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_termino { get; set; }
        public int limite_ouvintes { get; set; }
        public int sala { get; set; }
        public int status { get; set; }
        public int sala_id { get; set; }
        public int curso_id { get; set; }

        //Consultas
        public string autor { get; set; }
        public DateTime data { get; set; }
        public string curso { get; set; }
        public string orientador { get; set; }
        public string banca { get; set; }
        public int idBanca { get; set; }

        public bool CadBanca()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = @"insert into banca (titulo , data_banca, hora_inicio, hora_termino, limite_ouvintes, sala, status, sala_id, curso_id) values (@titulo , @data_banca, @hora_inicio, @hora_termino, @limite_ouvintes, @sala, status, @sala_id, @curso_id); ";
            c1.Parameters.Add("@titulo", SqlDbType.VarChar);
            c1.Parameters.Add("@data_banca", SqlDbType.Date);
            c1.Parameters.Add("@hora_inicio", SqlDbType.Time);
            c1.Parameters.Add("@hora_termino", SqlDbType.Time);
            c1.Parameters.Add("@limite_ouvintes", SqlDbType.Int);
            c1.Parameters.Add("@sala", SqlDbType.VarChar);
            c1.Parameters.Add("@status", SqlDbType.Int);
            c1.Parameters.Add("@sala_id", SqlDbType.Int);
            c1.Parameters.Add("@curso_id", SqlDbType.Int);
            c1.Parameters[0].Value = titulo;
            c1.Parameters[1].Value = data_banca;
            c1.Parameters[2].Value = hora_inicio;
            c1.Parameters[3].Value = hora_termino;
            c1.Parameters[4].Value = limite_ouvintes;
            c1.Parameters[5].Value = sala;
            c1.Parameters[6].Value = status;
            c1.Parameters[7].Value = sala_id;
            c1.Parameters[8].Value = curso_id;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception)
            {
                t1.Rollback();
                return false;
            }
            finally
            {
                b1.fecharConexao(cn1);
            }
        }

        public bool EditBanca()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = @"UPDATE banca SET titulo = @titulo, data_banca = @data_banca, 
            horario_inicio = @horario_inicio, horario_termino = @horario_termino, limite_ouvintes = @limite_ouvintes, status = @status, 
            sala_id = @sala_id, curso_id = @curso_id WHERE idBanca = @idBanca";
            c1.Parameters.Add("@titulo", SqlDbType.VarChar);
            c1.Parameters.Add("@data_banca", SqlDbType.Date);
            c1.Parameters.Add("@hora_inicio", SqlDbType.Time);
            c1.Parameters.Add("@hora_termino", SqlDbType.Time);
            c1.Parameters.Add("@limite_ouvintes", SqlDbType.Int);
            c1.Parameters.Add("@sala", SqlDbType.VarChar);
            c1.Parameters.Add("@status", SqlDbType.Int);
            c1.Parameters.Add("@sala_id", SqlDbType.Int);
            c1.Parameters.Add("@curso_id", SqlDbType.Int);
            c1.Parameters.Add("@idBanca", SqlDbType.Int);
            c1.Parameters[0].Value = idBanca;
            c1.Parameters[1].Value = titulo;
            c1.Parameters[2].Value = data_banca;
            c1.Parameters[3].Value = hora_inicio;
            c1.Parameters[4].Value = hora_termino;
            c1.Parameters[5].Value = limite_ouvintes;
            c1.Parameters[6].Value = sala;
            c1.Parameters[7].Value = status;
            c1.Parameters[8].Value = sala_id;
            c1.Parameters[9].Value = curso_id;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception)
            {
                t1.Rollback();
                return false;
            }
            finally
            {
                b1.fecharConexao(cn1);
            }

        }

        public bool DelBanca()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = @"DELETE FROM banca WHERE idBanca = @idBanca";
            c1.Parameters.Add("@idBanca", SqlDbType.Int);
            c1.Parameters[0].Value = idBanca;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception)
            {
                t1.Rollback();
                return false;
            }
            finally
            {
                b1.fecharConexao(cn1);
            }

        }

        public bool ConPorTitulo()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = @"SELECT titulo FROM banca WHERE titulo = @titulo";
            c1.Parameters.Add("@titulo", SqlDbType.VarChar);
            c1.Parameters[0].Value = titulo;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception)
            {
                t1.Rollback();
                return false;
            }
            finally
            {
                b1.fecharConexao(cn1);
            }
        }

        //public bool ConPorData()
        //{ }

        //public bool ConPorCurso()
        //{ }

        //public bool ConPorOrientador()
        //{ }

        //public bool ConBancaGeral()
        //{ }

        public bool ConLimOuvintes()
        {
            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = @"SELECT limite_ouvintes FROM banca WHERE titulo = @titulo";
            c1.Parameters.Add("@titulo", SqlDbType.VarChar);
            c1.Parameters[0].Value = titulo;

            try
            {
                c1.ExecuteNonQuery();
                t1.Commit();
                return true;
            }
            catch (Exception)
            {
                t1.Rollback();
                return false;
            }
            finally
            {
                b1.fecharConexao(cn1);
            }

        }
    }
}
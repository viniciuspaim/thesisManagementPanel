using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace thesisManagementPanel
{
    public class Usuario
    {
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string cpf { get; set; }

        public bool cadastrarUsuario()
        {

            Banco b1 = new Banco();
            SqlConnection cn1 = b1.abrirconexao();
            SqlTransaction t1 = null;
            SqlCommand c1 = new SqlCommand();
            t1 = cn1.BeginTransaction();
            c1.Connection = cn1;
            c1.Transaction = t1;
            c1.CommandType = System.Data.CommandType.Text;
            c1.CommandText = "insert into usuario (nome , login, senha, email, celular, cpf) values (@nome,@login,@senha,@email,@celular,@cpf); ";
            c1.Parameters.Add("@nome", SqlDbType.VarChar);
            c1.Parameters.Add("@login", SqlDbType.VarChar);
            c1.Parameters.Add("@senha", SqlDbType.VarChar);
            c1.Parameters.Add("@email", SqlDbType.VarChar);
            c1.Parameters.Add("@celular", SqlDbType.VarChar);
            c1.Parameters.Add("@cpf", SqlDbType.VarChar);
            c1.Parameters[0].Value = nome;
            c1.Parameters[1].Value = login;
            c1.Parameters[2].Value = senha;
            c1.Parameters[3].Value = email;
            c1.Parameters[4].Value = celular;
            c1.Parameters[5].Value = cpf;

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

        //public bool editarUsuario()
        //{

        //}

        //public bool excluirUsuario()
        //{ }

        //public bool consultarUsuario()
        //{ }

    }
}
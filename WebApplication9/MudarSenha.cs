using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace thesisManagementPanel
{
    public class MudarSenha
    {
        public string senhaantiga { get; set; }
        public string senhanova { get; set; }
        public string senhanova2 { get; set; }
        public string usuario { get; set; }

        public bool trocapass()
        {
            Banco b1 = new Banco();

            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(senhaantiga));

            byte[] result = md5.Hash;

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }

            string senha = stringBuilder.ToString();

            string senhabanco;

            SqlConnection con = b1.abrirconexao();
            string chkPassQuery = "select senha from usuario where login ='" + usuario + "'";
            SqlCommand cnpwd = new SqlCommand(chkPassQuery, con);
            senhabanco = cnpwd.ExecuteScalar().ToString();

            if (senhanova == senhanova2)
            {
                if (senha == senhabanco)
                {

                    MD5 md5s = new MD5CryptoServiceProvider();

                    md5s.ComputeHash(ASCIIEncoding.ASCII.GetBytes(senhanova));

                    byte[] results = md5s.Hash;

                    StringBuilder stringBuilders = new StringBuilder();
                    for (int i = 0; i < results.Length; i++)
                    {
                        stringBuilders.Append(results[i].ToString("x2"));
                    }

                    string novasenha = stringBuilders.ToString();

                    SqlConnection cn1 = b1.abrirconexao();
                    SqlTransaction t1 = null;
                    SqlCommand c1 = new SqlCommand();
                    t1 = cn1.BeginTransaction();
                    c1.Connection = cn1;
                    c1.Transaction = t1;
                    c1.CommandType = System.Data.CommandType.Text;
                    c1.CommandText = "update usuario set senha = @novasenha WHERE login = @usuario";
                    c1.Parameters.Add("@novasenha", SqlDbType.VarChar);
                    c1.Parameters.Add("@usuario", SqlDbType.VarChar);
                    c1.Parameters[0].Value = novasenha;
                    c1.Parameters[1].Value = usuario;

                    try
                    {
                        c1.ExecuteNonQuery();
                        t1.Commit();
                        return true;
                    }
                    catch (Exception ex)
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

            return false;
        }
    }
}
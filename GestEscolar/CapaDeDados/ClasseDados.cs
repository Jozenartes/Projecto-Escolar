using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidade;
using System.Data.SqlClient; //Biblioteca para Sqlconnection
using System.Data;
using System.Configuration;

                        //Codio de Login do Projecto
namespace CapaDeDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable DLogin(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logar", con);//Login process I think
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@senha", obje.senha);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

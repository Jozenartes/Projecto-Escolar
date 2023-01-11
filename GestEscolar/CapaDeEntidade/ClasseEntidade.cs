using System;
using System.Data;
using CapaDeNegocios;
namespace CapaDeEntidade
{
    public class ClasseEntidade
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public DataTable N_Login(global::CapaDeNegocios.ClasseNegocio clsUser)
        {
            throw new NotImplementedException();
        }
    }
}

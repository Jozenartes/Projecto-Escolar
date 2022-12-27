using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDados;//
using CapaDeEntidade;//
using System.Data; //libary for DataTable

namespace CapaDeNegocio
{
    public class ClasseNegocio
    {
        ClasseDados clsDados = new ClasseDados();
        public DataTable N_Login(ClasseEntidade obje)
        {
            return clsdados.DLogin(obje);
        }
    }
}

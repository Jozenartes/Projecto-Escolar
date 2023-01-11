using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeNegocios
{
    public class ClasseNegocio
    {

        public DataTable N_Login(ClasseEntidade obje)
        {
            return clsDados.DLogin(obje);
        }
    }
}

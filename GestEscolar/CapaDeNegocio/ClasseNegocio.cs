﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDados;
using CapaDeEntidade;
using System.Data; //libary for DataTable
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDeNegocio
{
    public class ClasseNegocio
    {
        ClasseDados clsDados = new ClasseDados();

        public string usuario { get; set; } //propriedade usuario criado para referenciar na ClasseEntidade
        public string senha { get; set; }

        public DataTable N_Login(ClasseEntidade clsUser)
        {
            throw new NotImplementedException();
        }
    }
}
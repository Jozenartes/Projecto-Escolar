using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio;

namespace Formularios
{
    public partial class Form1 : Form
    {
        ClasseNegocio clsUser = new ClasseNegocio();
        ClasseEntidade clsEnt = new ClasseEntidade();

        public static string usuario_nome, //nome do usuario
                             id_tipo, //tipo do usuario a logar
                             usuario_geral, 
                             usuario_codigo;

        FrmPrincipal f = new FrmPrincipal();

        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }
    } 
}

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

        private void button1_Click(object sender, EventArgs e)
        {   //reconhecimento do usuario e a senha
            DataTable dt = new DataTable();

            clsUser.usuario = textBox1.Text;
            clsEnt.senha = textBox2.Text; //assigning the value the passes from senha to textbox2

            dt = clsEnt.N_Login(clsUser);
            //Condição de entrada
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bem Vindo" + dt.Rows[0][0].ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nome = dt.Rows[0][0].ToString();
                id_tipo = dt.Rows[0][1].ToString();
                usuario_geral = dt.Rows[0][2].ToString();
                usuario_codigo = dt.Rows[0][3].ToString();
                this.Hide();
                f.ShowDialog();
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha errada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }

        

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

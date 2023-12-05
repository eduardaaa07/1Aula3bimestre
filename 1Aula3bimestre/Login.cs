using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Aula3bimestre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txbusuario.Text;
            string senha = txbsenha.Text;

             UsuarioDAO usuariologin = new UsuarioDAO();
           
            if (usuariologin.Login(usuario, senha)) { 
               
                Form1 tela = new Form1();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique os dados inseridos!",
                    "ERROOOO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1   forms1 = new Form1();
            forms1.Show();
        }
    }
}

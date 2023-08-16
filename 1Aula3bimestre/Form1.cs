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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
           string nome = txbNome.Text;
            string enrollment  = txbPront.Text;

            string message = "Nome: " + nome +
                            "\nMatricula: " + enrollment;

            MessageBox.Show(
                "message",
                " Seja bem vindo!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}

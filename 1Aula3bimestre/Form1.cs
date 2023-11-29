using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Aula3bimestre
{
    public partial class Form1 : Form
    {
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
           
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> users = usuarioDAO.SelectUser();
           
            try
            {
                foreach (Usuario usuario in users) {

                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.Nome);
                    lv.SubItems.Add(usuario.Email);
                    lv.SubItems.Add(usuario.Senha);
                    listView1.Items.Add(lv);
                

                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnmessage_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txbemail.Text,
            txbusuario.Text,
            txbsenha.Text);
          UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.insertUsuario(usuario);
               
                MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbemail.Clear();
            txbusuario.Clear();
            txbsenha.Clear();

            UpdateListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void btmedt_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txbemail.Text,
             txbusuario.Text,
             txbsenha.Text);
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.EditUsuario(usuario);

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbemail.Clear();
            txbusuario.Clear();
            txbsenha.Clear();

            UpdateListView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbemail.Text = listView1.Items[index].SubItems[1].Text;
            txbusuario.Text = listView1.Items[index].SubItems[2].Text;
            txbsenha.Text = listView1.Items[index].SubItems[3].Text;

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE Livro WHERE ID = @iD";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            txbemail.Clear();
            txbusuario.Clear();
            txbsenha.Clear();

            UpdateListView();

        }

        private void txbemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

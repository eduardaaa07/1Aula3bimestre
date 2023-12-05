using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Aula3bimestre
{
    public partial class Livro : Form
    {
        private int ID; 

        public Livro()
        {
            InitializeComponent();
        }

        private void btnexclu_Click(object sender, EventArgs e)
        {

            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Livro WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
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
            txblivro.Clear();
            txbautor.Clear();
            txbgenero.Clear();

           
        }

        private void btncadrasto_Click(object sender, EventArgs e)
        {
            Livro1 livro = new Livro1(ID, txblivro.Text,
          txbautor.Text,
          txbgenero.Text);
            LivroDAO usuarioDAO = new LivroDAO();
            usuarioDAO.insertLivro(livro);
            MessageBox.Show("Cadastrado do livro feito com sucesso",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            txblivro.Clear();
            txbautor.Clear();
            txbgenero.Clear();

            UpdateListView();
        }

        private void btnedts_Click(object sender, EventArgs e)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Livro SET 
              
              Livro = @senha,
              Autor= @nome
               WHERE  EMAIL = @email";

            sqlCommand.Parameters.AddWithValue("@livro", txblivro.Text);
            sqlCommand.Parameters.AddWithValue("@autor", txbautor.Text);
            sqlCommand.Parameters.AddWithValue("@genero", txbgenero.Text);


            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txblivro.Clear();
            txbautor.Clear();
            txbgenero.Clear();

            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                int index;
                index = listView1.FocusedItem.Index;
                ID = int.Parse(listView1.Items[index].SubItems[0].Text);
                txblivro.Text = listView1.Items[index].SubItems[1].Text;
                txbautor.Text = listView1.Items[index].SubItems[2].Text;
                txbgenero.Text = listView1.Items[index].SubItems[3].Text;

        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> users = usuarioDAO.SelectUser();

            try
            {
                foreach (Usuario usuario in users)
                {

                    ListViewItem lv = new ListViewItem(ID.ToString());
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

    }
}

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
    public partial class FormLivro : Form
    {
        private int ID; 

        public FormLivro()
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

            UpdateListView();
        }

        private void btncadrasto_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(ID, txblivro.Text,
          txbautor.Text,
          txbgenero.Text);
            LivroDAO usuarioDAO = new LivroDAO();
            usuarioDAO.insertLivro(livro);
            MessageBox.Show("Cadastrado do livro feito com sucesso",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            Email email = new Email();
            email.Show(); 

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
              
              Livro = @livro,
              Autor = @autor,
              Genero = @genero

               WHERE ID = @ID";

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

            LivroDAO livroDAO = new LivroDAO();
            List<Livro> livro = livroDAO.SelectLivro();

            try
            {
                foreach (Livro live in livro)
                {

                    ListViewItem lv = new ListViewItem(live.ID.ToString());
                    lv.SubItems.Add(live.Nomelivro);
                    lv.SubItems.Add(live.Autor);
                    lv.SubItems.Add(live.Genero);
                    listView1.Items.Add(lv);


                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void Livro_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            ID = int.Parse(listView1.Items[index].SubItems[0].Text);
            txblivro.Text = listView1.Items[index].SubItems[1].Text;
            txbautor.Text = listView1.Items[index].SubItems[2].Text;
            txbgenero.Text = listView1.Items[index].SubItems[3].Text;
        }
    }
}

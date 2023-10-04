using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM usuario";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string usuario= (string)dr["Usuario"];
                    string email = (string)dr["Email"];
                    string senha = (string)dr["Senha"];
                    
                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(usuario);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(senha);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnmessage_Click_1(object sender, EventArgs e)
        {
           Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO usuario VALUES
            (@Email, @Usuario, @Senha)";

            sqlCommand.Parameters.AddWithValue("@Email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@Usuario", txbusuario.Text);
            sqlCommand.Parameters.AddWithValue("@Senha", txbsenha.Text);

            sqlCommand.ExecuteNonQuery();

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
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE  usuario SET
            Email = @Email,
            Usuario = @Usuario,
            Senha = @Senha
            WHERE Id = @id";

            sqlCommand.Parameters.AddWithValue("@Email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@Usuario", txbusuario.Text);
            sqlCommand.Parameters.AddWithValue("@Senha", txbsenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);
            sqlCommand.ExecuteNonQuery();

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

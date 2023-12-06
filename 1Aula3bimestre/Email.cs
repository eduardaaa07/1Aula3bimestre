using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1Aula3bimestre
{
    public partial class Email : Form
    {
        private readonly string DataBase = "Livros";

        public Email()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Define as propriedades do SaveFileDialog
            saveFileDialog.Filter = "Arquivos PDF (.pdf)|.pdf|Todos os arquivos (.)|.";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            // Exibe o diálogo e verifica se o usuário pressionou OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                /// Obtém o caminho escolhido pelo usuário
                string filePath = saveFileDialog.FileName;

                // Conexão com o banco de dados SQL Server
                string stringConnection = @"Data Source="
                         + Environment.MachineName +
                         @"\SQLEXPRESS;Initial Catalog=" +
                         DataBase + ";Integrated Security=true";
                SqlConnection connection = new SqlConnection(stringConnection);
                connection.Open();

                // Consulta SQL para recuperar as informações
                string query = "SELECT Usuario, Email, Senha FROM usuario";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Cria um novo documento PDF
                Document document = new Document();

                try
                { // Cria um PdfWriter usando o caminho escolhido pelo usuário
                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    // Abre o documento antes de adicionar elementos
                    document.Open();

                    // Cria uma nova tabela e adiciona as informações recuperadas
                    PdfPTable table = new PdfPTable(2);
                    table.AddCell("Usuario");
                    table.AddCell("Email");
                    table.AddCell("Senha");

                    while (reader.Read())
                    {
                        table.AddCell(reader["Usuario"].ToString());
                        table.AddCell(reader["Email"].ToString());
                        table.AddCell(reader["Senha"].ToString());
                    }

                    // Adiciona a tabela ao documento
                    document.Add(table);

                    MessageBox.Show("Relatório gerado com sucesso", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    // Fecha o documento e a conexão com o banco de dados
                    document.Close();
                    connection.Close();
                }
            }
        }
    }
}

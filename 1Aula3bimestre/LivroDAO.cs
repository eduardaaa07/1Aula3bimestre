using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Aula3bimestre
{
    public class LivroDAO
    {
        public void insertLivro(Livro livro)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Livro VALUES
            (@livro, @autor, @genero)";

            sqlCommand.Parameters.AddWithValue("@livro", livro.Nomelivro);
            sqlCommand.Parameters.AddWithValue("@autor", livro.Autor);
            sqlCommand.Parameters.AddWithValue("@genero", livro.Genero);

            sqlCommand.ExecuteNonQuery();

        }
        public List<Livro> SelectLivro()
        {
            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Livro";

            List<Livro> livro = new List<Livro> ();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Livro objeto = new Livro(

                  (int)dr["ID"],
                  (string)dr["Livro"],
                  (string)dr["Autor"],
                  (string)dr["Genero"]
                        );
                    livro.Add(objeto);

                }
                dr.Close();
                return livro;
            }
            catch (Exception err)
            {
                throw new Exception(" Erro na leitura.\n " +
                    err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return livro;
        }
       

        public void EditLivro(Livro livro)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "SELECT * FROM Livro WHERE " +
                     "@ID, @Livro, @Autor, @Genero)";

                sqlCommand.Parameters.AddWithValue("@Livro", livro.Nomelivro);
                sqlCommand.Parameters.AddWithValue("@Autor", livro.Autor);
                sqlCommand.Parameters.AddWithValue("@Genero", livro.Genero);
                sqlCommand.Parameters.AddWithValue("@ID", livro.ID);

                Console.WriteLine("Comando SQL a ser executado: " + sqlCommand.CommandText);
                Console.WriteLine("Livro: " + livro.Nomelivro);
                Console.WriteLine("Autor: " + livro.Autor);
                Console.WriteLine("Genero: " + livro.Genero);
                Console.WriteLine("ID: " + livro.ID);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                Console.WriteLine("Linhas afetadas: " + rowsAffected);
            }
            catch (SqlException sqlEx)
            {

                Console.WriteLine("Erro SQL ao editar dados: " + sqlEx.Message);
                throw;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao editar dados: " + ex.Message);
                throw;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

    }
}


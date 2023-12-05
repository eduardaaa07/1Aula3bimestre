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
        public void insertLivro(Livro1 livro)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Livro VALUES
            ( @ID, @livro, @autor, @genero)";

            sqlCommand.Parameters.AddWithValue("@livro", livro.livro2);
            sqlCommand.Parameters.AddWithValue("@autor", livro.Autor);
            sqlCommand.Parameters.AddWithValue("@genero", livro.Genero);
            sqlCommand.Parameters.AddWithValue("@ID", livro.ID);

            sqlCommand.ExecuteNonQuery();

        }
        public List<Livro1> SelectLivro()
        {
            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Livro";

            List<Livro1> livro = new List<Livro1> ();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Livro1 objeto = new Livro1(

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
        public bool Login(string usuario, string senha)
        {
            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Livro WHERE " +
                " Livro = @Usuario AND senha = @Senha";

            sqlCom.Parameters.AddWithValue("@Usuario", usuario);
            sqlCom.Parameters.AddWithValue("@Senha", senha);



            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();


                if (dr.HasRows)
                {
                    dr.Close();
                    return true;
                }
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
            return false;
        }

        public void EditLivro(Usuario usuario)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "SELECT * FROM Livro WHERE " +
                    " Usuario = @Usuario AND senha = @Senha";


                sqlCommand.Parameters.AddWithValue("@Email", usuario.Email);
                sqlCommand.Parameters.AddWithValue("@Usuario", usuario.Nome);
                sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);
                sqlCommand.Parameters.AddWithValue("@ID", livro.Id);

                Console.WriteLine("Comando SQL a ser executado: " + sqlCommand.CommandText);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Usuário: " + usuario.Nome);
                Console.WriteLine("Senha: " + usuario.Senha);
                Console.WriteLine("ID: " + usuario.Id);

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


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Aula3bimestre
{
    public class UsuarioDAO
    {
        public void insertUsuario(Usuario usuario)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO usuario VALUES
            (@Email, @Usuario, @Senha)";

            sqlCommand.Parameters.AddWithValue("@Email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@Usuario", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);

            sqlCommand.ExecuteNonQuery();
        }
        public List<Usuario> SelectUser()
        {
            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM usuario";

            List<Usuario> users = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(

                  (int)dr["Id"],
                  (string)dr["Email"],
                  (string)dr["Usuario"],
                  (string)dr["Senha"]
                        );
                    users.Add(objeto);

                }
                dr.Close();
                return users;
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
            return null;
        }
        public bool Login( string usuario, string senha)
        {
            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM usuario WHERE " +
                " Usuario = @Usuario AND senha = @Senha";

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

        public void EditUsuario(Usuario usuario)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE usuario 
                               SET Email = @Email, Usuario = @Usuario, Senha = @Senha
                               WHERE Id = @Id";

            sqlCommand.Parameters.AddWithValue("@Email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@Usuario", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.Id);  

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
                throw new Exception("Erro ao editar dados: " + ex.Message);
            }
            finally
            {
                connection.CloseConnection(); 
            }
        }

    }
}








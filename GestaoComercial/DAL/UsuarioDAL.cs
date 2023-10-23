using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText=@"INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo) 
                                    VALUES(@Nome, @Senha, @Ativo)" ;

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir o usuario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
           
        }
        public void Alterar(Usuario _usuario)
        {
            string connectionString = Constantes.StringDeConexao;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    string sql = @"UPDATE Usuario
                           SET Nome = @Nome,
                               NomeUsuario = @NomeUsuario,
                               Senha = @Senha,
                               Ativo = @Ativo
                           WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                        cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                        cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                        cmd.Parameters.AddWithValue("@Id", _usuario.Id); // Certifique-se de que sua classe Usuario tenha uma propriedade Id

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar atualizar o usuário no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public void Excluir(int _id)
        {
            string connectionString = Constantes.StringDeConexao;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    string sql = @"DELETE FROM Usuario WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", _id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar excluir o usuário no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public List<Usuario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            
            

            List<Usuario> usuariosList = new List<Usuario>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while(rd.Read()){
                        Usuario usuario= new Usuario();
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuariosList.Add(usuario);

                    }
                }
                return usuariosList;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar novos usuarios");
            }
            finally
            {
                cn.Close();
            }
            
        }
        public Usuario BuscarPorId(int _id)
        {
            Usuario usuario;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario Where Id=@Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    usuario = new Usuario();
                    if (rd.Read())
                    {
                        
                        usuario.Id = (int)rd["Id"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        

                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar novos usuarios");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

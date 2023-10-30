using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Fone { get; set; }

        public void Inserir()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"INSERT INTO Cliente(Nome, Fone) 
                              VALUES(@Nome, @Fone)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Fone", this.Fone);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar inserir o cliente no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public void Alterar()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"UPDATE Cliente
                              SET Nome = @Nome,
                                  Fone = @Fone
                              WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Fone", this.Fone);
                        cmd.Parameters.AddWithValue("@Id", this.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar atualizar o cliente no banco de dados.", ex);
                }
            }
        }

        public void Excluir()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"DELETE FROM Cliente WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", this.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar excluir o cliente no banco de dados.", ex);
                }
            }
        }

        public List<Cliente> BuscarTodos()
        {
            Cliente cliente;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Cliente> clientelist = new List<Cliente>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select Id,Nome, Fone from Cliente";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        clientelist.Add(cliente);
                    }

                }
                return clientelist;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar os cliente.", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public Cliente BuscarPorFone(string Fone)
        {

            Cliente cliente;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select Id, Nome,Fone from Cliente WHERE Fone LIKE @Fone";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Fone", Fone+ "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {

                    cliente = new Cliente();
                    while (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                    }
                }

                return cliente;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Cliente> BuscarPorNome(string _nome)
        {

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Cliente> clienteList = new List<Cliente>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select Id, Nome,Fone from Cliente WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Fone = rd["Fone"].ToString();
                        clienteList.Add(cliente);

                    }
                }
                return clienteList;
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

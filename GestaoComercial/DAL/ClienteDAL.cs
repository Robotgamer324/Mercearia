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
    }

}

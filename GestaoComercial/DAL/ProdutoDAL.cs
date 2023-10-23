using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ProdutoDAL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Estoque { get; set; }

        public void Inserir()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"INSERT INTO Produto(Nome, Preco, Estoque) 
                              VALUES(@Nome, @Preco, @Estoque)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Preco", this.Preco);
                        cmd.Parameters.AddWithValue("@Estoque", this.Estoque);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados.", ex);
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

                    string sql = @"UPDATE Produto
                              SET Nome = @Nome,
                                  Preco = @Preco,
                                  Estoque = @Estoque
                              WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Preco", this.Preco);
                        cmd.Parameters.AddWithValue("@Estoque", this.Estoque);
                        cmd.Parameters.AddWithValue("@Id", this.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar atualizar o produto no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
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

                    string sql = @"DELETE FROM Produto WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", this.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar excluir o produto no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}

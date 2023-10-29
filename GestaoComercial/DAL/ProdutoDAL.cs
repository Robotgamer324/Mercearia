using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public List<Produto> BuscarTodos()
        {
            Produto produto;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Produto> produtoList = new List<Produto>();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select Id, Nome, Preco,Estoque,codigoDeBarras from Produto";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Estoque = (int)rd["Estoque"];
                        produto.codigoDeBarras = rd["codigoDeBarras"].ToString();
                        produtoList.Add(produto);
                    }
                }
                return produtoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Produto BuscarPorId(int _id)
        {
            Produto produto;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nome,Preco,Estoque FROM Produto WHERE Id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id",_id + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    while (rd.Read())
                    {
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Estoque = (int)rd["Estoque"];
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto> BuscarPorNome(string _nome)
        {
            Produto produto;
            List<Produto> produtoList = new List<Produto>();
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Id, Nome,Preco,Estoque,codigoDeBarras
                                   FROM Produto
                                   WHERE Nome LIKE  @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome",_nome + "%");
                cn.Open();
                using ( SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = PreencherObjto(rd);
                        produtoList.Add(produto);
                    }
                }
                return produtoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto> BuscarPorCodigoDeBarras(string _barras)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Produto> produtoList = new List<Produto>();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select Id, Nome, Preco,Estoque,codigoDeBarras from Produto where codigoDeBarras Like @codigoDeBarras;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@codigoDeBarras", _barras +"%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        produto = PreencherObjto(rd);
                        produtoList.Add(produto);
                    }
                }
                return produtoList;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar novos Produtos");
            }
            finally
            {
                cn.Close();
            }       
        }

        private static Produto PreencherObjto(SqlDataReader rd)
        {
            Produto produto = new Produto();
            produto.Id = (int)rd["Id"];
            produto.Nome = rd["Nome"].ToString();
            produto.Estoque = (int)rd["Estoque"];
            produto.Preco = (double)rd["Preco"];
            produto.codigoDeBarras = rd["codigoDeBarras"].ToString();
            return produto;
        }
    }
}


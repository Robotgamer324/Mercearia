using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Constantes
    {
        // 1. Deixamos a string real protegida
        private static string _stringBase = @"Data Source=Gabriel\SQLEXPRESS2019A;Initial Catalog=Mercearia;User ID=SA;Password=Senailab02";

        // 2. Propriedade inteligente: Ela tenta validar antes de retornar o valor
        public static string StringDeConexao
        {
            get
            {
                if (ValidarConexao())
                {
                    return _stringBase;
                }
                else
                {
                    // Se falhar, podemos retornar vazio ou lançar um erro personalizado
                    throw new Exception("A conexão com o banco de dados Mercearia falhou. Verifique o servidor.");
                }
            }
        }

        public static bool ValidarConexao()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(_stringBase))
                {
                    conexao.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoBLL
    {
        

        public void Inserir()
        {
            new ProdutoDAL().Inserir();
        }

        public void Alterar()
        {
            new ProdutoDAL().Alterar();
        }

        public void Excluir()
        {
           new ProdutoDAL().Excluir();
        }

        public List<Produto> BuscarTodos()
        {
          return new ProdutoDAL().BuscarTodos();
        }

        public Produto BuscarPorId(int _id)
        {
           return new ProdutoDAL().BuscarPorId(_id);
        }
        public List<Produto> BuscarPorNome(string _nome)
        {
            return new ProdutoDAL().BuscarPorNome(_nome);
        }
        public List<Produto> BuscarPorCodigoDeBarras(string _codigo)
        {
            return new ProdutoDAL().BuscarPorCodigoDeBarras(_codigo);
            
        }

    }
}



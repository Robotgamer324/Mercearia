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
    public class ClienteBLL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Fone { get; set; }

        public void Inserir()
        {
            new ClienteDAL().Inserir();
        }
        public void Alterar()
        {
           new ClienteDAL().Alterar();
        }
        public void Excluir()
        {
            new ClienteDAL().Excluir();
        }
        public List<Cliente> BuscarTodos()
        {
             return new ClienteDAL().BuscarTodos();
        }
        public Cliente BuscarPorFone(string _Fone)
        {
           return new ClienteDAL().BuscarPorFone(_Fone);
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
             return new ClienteDAL().BuscarPorNome(_nome);
        }
    }
}


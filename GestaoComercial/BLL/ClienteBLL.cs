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
            new ClienteDAL().BuscarTodos();
        }
        public Cliente BuscarPorId(int id)
        {
           new ClienteDAL().BuscarPorId(id);
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            new ClienteDAL().BuscarPorNome(_nome);
        }
    }
}


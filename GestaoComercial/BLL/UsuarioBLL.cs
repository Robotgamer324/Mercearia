using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir (Usuario _usuario)
        {
            if (string.IsNullOrEmpty(_usuario.Nome))
                throw new Exception("Informe o nome do usuário.");

            new UsuarioDAL().Inserir(_usuario);
        }

    }
}

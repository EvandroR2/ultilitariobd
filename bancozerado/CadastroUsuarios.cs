using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancozerado
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario (){Nome = "evandro", Senha = "123"},
            new Usuario (){Nome = "pdvnet", Senha = "net010"},
            new Usuario (){Nome = "PDVNET", Senha = "net010"},
            new Usuario (){Nome = "00987654", Senha = "net010"}




        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {

            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }

            }

            return false;

        }
    }
}

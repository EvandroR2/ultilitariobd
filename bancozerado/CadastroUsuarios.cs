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
            new Usuario (){Nome = "EVANDRO", Senha = "123"},
            new Usuario (){Nome = "00987654", Senha = "1"},
            new Usuario (){Nome = "PDVNET", Senha = "1"},
            new Usuario (){Nome = "PDVNET", Senha = "NET010"},
            new Usuario (){Nome = "00987654", Senha = "NET010"}




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

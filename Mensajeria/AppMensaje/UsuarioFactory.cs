using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class UsuarioFactory
    {
        private static Dictionary<string, string> _usuarios = new Dictionary<string, string>();

        public static string ObtenerUsuario(string nombre)
        {
            if (!_usuarios.ContainsKey(nombre))
                _usuarios[nombre] = nombre;
            return _usuarios[nombre];
        }
    }
}

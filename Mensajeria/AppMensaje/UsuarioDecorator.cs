using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class UsuarioDecorator : MensajeDecorator
    {
        private string _usuario;

        public UsuarioDecorator(IMensaje mensaje, string usuario) : base(mensaje)
        {
            _usuario = usuario;
        }

        public override string ObtenerContenido()
        {
            return $"{_usuario}: {_mensaje.ObtenerContenido()}";
        }
    }
}

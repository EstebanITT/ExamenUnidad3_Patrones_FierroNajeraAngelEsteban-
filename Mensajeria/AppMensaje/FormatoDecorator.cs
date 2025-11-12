using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class FormatoDecorator : MensajeDecorator
    {
        public FormatoDecorator(IMensaje mensaje) : base(mensaje) { }

        public override string ObtenerContenido()
        {
            string contenido = _mensaje.ObtenerContenido();
            return "[Mensaje]: " + contenido;
        }
    }
}

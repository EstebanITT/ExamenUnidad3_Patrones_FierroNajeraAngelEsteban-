using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class CifradoDecorator : MensajeDecorator
    {
        public CifradoDecorator(IMensaje mensaje) : base(mensaje) { }

        public override string ObtenerContenido()
        {
            string contenido = _mensaje.ObtenerContenido();
            char[] cifrado = new string('*', contenido.Length).ToCharArray();
            return new string(cifrado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class FechaDecorator : MensajeDecorator
    {
        public FechaDecorator(IMensaje mensaje) : base(mensaje) { }

        public override string ObtenerContenido()
        {
            return $"[{DateTime.Now.ToShortTimeString()}] {_mensaje.ObtenerContenido()}";
        }
    }
}

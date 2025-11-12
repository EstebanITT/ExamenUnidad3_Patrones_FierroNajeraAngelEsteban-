using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public abstract class MensajeDecorator : IMensaje
    {
        protected IMensaje _mensaje;

        public MensajeDecorator(IMensaje mensaje)
        {
            _mensaje = mensaje;
        }

        public abstract string ObtenerContenido();
    }
}

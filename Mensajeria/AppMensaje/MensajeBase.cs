using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class MensajeBase : IMensaje
    {
        private string _contenido;

        public MensajeBase(string contenido)
        {
            _contenido = contenido;
        }

        public string ObtenerContenido()
        {
            return _contenido;
        }
    }

}

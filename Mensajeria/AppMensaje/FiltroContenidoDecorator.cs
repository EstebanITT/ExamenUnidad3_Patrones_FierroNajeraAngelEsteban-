using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppMensaje
{
    public class FiltroContenidoDecorator : MensajeDecorator
    {
        public FiltroContenidoDecorator(IMensaje mensaje) : base(mensaje) { }

        public override string ObtenerContenido()
        {
            string contenido = _mensaje.ObtenerContenido();
            contenido = Regex.Replace(contenido, "(tonto|feo|idiota)", "***", RegexOptions.IgnoreCase);
            return contenido;
        }
    }
}

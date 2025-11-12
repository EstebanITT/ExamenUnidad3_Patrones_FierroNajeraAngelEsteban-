using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppMensaje
{

    public class EmojiSugerencia
    {
        private static Dictionary<string, string> _emojiFlyweights = new Dictionary<string, string>();
        private static Dictionary<string, int> _usoEmojis = new Dictionary<string, int>();

        public static string ObtenerEmoji(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
                return "";

            string clave = palabra.ToLower();

            if (_emojiFlyweights.ContainsKey(clave))
            {
                _usoEmojis[_emojiFlyweights[clave]]++;
                return _emojiFlyweights[clave];
            }

            string emoji = "";
            switch (clave)
            {
                case "feliz": emoji = ":)"; break;
                case "triste": emoji = ":("; break;
                case "amor": emoji = "<3"; break;
                case "risa": emoji = ":D"; break;
                case "ok": emoji = ":}"; break;
                case "gracias": emoji = ":DD"; break;
                case "hola": emoji = "(o_o)/"; break;
                default: emoji = ""; break;
            }

            if (emoji != "")
            {
                _emojiFlyweights[clave] = emoji;
                _usoEmojis[emoji] = 1;
            }

            return emoji;
        }

        public static IEnumerable<string> ObtenerEmojisUsados()
        {
            return _emojiFlyweights.Values;
        }

        public static string ObtenerEmojiMasUsado()
        {
            string top = "";
            int max = 0;
            foreach (var item in _usoEmojis)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    top = item.Key;
                }
            }
            return top == "" ? "Ninguno" : top;
        }
    }
}

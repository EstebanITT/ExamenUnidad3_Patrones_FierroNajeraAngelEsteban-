using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppMensaje
{
    class Program
    {
        static List<string> historial = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "App de Mensajería - Decorator + Flyweight";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Sistema de Mensajería con Filtros, Emojis y Decoradores ===\n");

            Console.Write("Ingresa tu nombre de usuario: ");
            string nombre = Console.ReadLine();
            string usuario = UsuarioFactory.ObtenerUsuario(nombre);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nEscribe un mensaje (o 'historial' / 'salir'): ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "salir")
                    break;

                if (entrada.ToLower() == "historial")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n=== Historial de mensajes ===");
                    foreach (var msg in historial)
                        Console.WriteLine(msg);
                    continue;
                }

                
                IMensaje mensaje = new MensajeBase(entrada);
                mensaje = new FiltroContenidoDecorator(mensaje);
                mensaje = new FormatoDecorator(mensaje);
                mensaje = new FechaDecorator(mensaje);
                mensaje = new UsuarioDecorator(mensaje, usuario);

                string final = mensaje.ObtenerContenido();

                historial.Add(final);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMensaje enviado: " + final);

                
                string[] palabras = entrada.Split(' ');
                foreach (string palabra in palabras)
                {
                    string emoji = EmojiSugerencia.ObtenerEmoji(palabra);
                    if (!string.IsNullOrEmpty(emoji))
                        Console.WriteLine($"Sugerencia de emoji para '{palabra}': {emoji}");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nEmojis más usados hasta ahora:");
                foreach (string emoji in EmojiSugerencia.ObtenerEmojisUsados())
                    Console.Write(emoji + " ");
                Console.WriteLine("\nMás usado: " + EmojiSugerencia.ObtenerEmojiMasUsado());
            }

            
            File.WriteAllLines("historial_chat.txt", historial);
            Console.WriteLine("\nHistorial guardado en historial_chat.txt");
        }
    }
}

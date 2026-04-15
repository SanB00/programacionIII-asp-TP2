using System.Linq;
using System.Text.RegularExpressions;

namespace TP2Grupo18
{
    public class Common
    {
        public static string eliminarEspaciosDelTexto(string texto) {
            return Regex.Replace(texto.Trim(), @"\s+", " ");
        }

        public static bool esUnNroValido(string texto) {
            //texto.All(char.IsDigit)
            return int.TryParse(texto, out int nroValidar) && nroValidar > 0;
        }
        public static bool esSoloLetras(string texto) {
            return texto.All(char.IsLetter);
        }
    }
}
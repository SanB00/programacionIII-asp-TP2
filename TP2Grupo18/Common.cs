<<<<<<< HEAD
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
=======
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
        public static void mostrarMensajeEnAlerta(string mensaje, System.Web.UI.Page page) {
            string safeMessage = mensaje.Replace("'", "\\'").Replace("\n", "\\n");
            page.ClientScript.RegisterStartupScript(page.GetType(),
                "alert",
                $"alert('{safeMessage}');",
                true);
        }
    }
>>>>>>> e36d4de (test "Initial commit")
}
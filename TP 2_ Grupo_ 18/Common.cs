using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace TP2Grupo18
{
    public class Common
    {
        public static string eliminarEspaciosDelTexto(string texto) {
            return Regex.Replace(texto.Trim(), @"\s+", " ");
        }

        public static bool esUnNroValido(string texto) {
            return int.TryParse(texto, out int nroValidar) || nroValidar <= 0;
        }

        public static void mostrarErrorCuandoNoEsNumero(string texto, System.Web.UI.Page page) {
            // if (!int.TryParse(texto, out int nroValidar) || nroValidar <= 0) {

            int nroValidar;
            if (!int.TryParse(texto, out nroValidar) || nroValidar <= 0) {
                //throw new FormatException("El valor ingresado no es un número válido.");
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert",
                    "alert('Ingrese un número válido');", true);
            }
        }
    }
}
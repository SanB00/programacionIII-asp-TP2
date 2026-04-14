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
    }
}
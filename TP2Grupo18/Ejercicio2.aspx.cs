using System;

namespace TP2Grupo18
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnVerResumen_Click(object sender, EventArgs e) {
<<<<<<< HEAD
            String strNombre = Common.eliminarEspaciosDelTexto(txtNombre.Text);
            String strApellido = Common.eliminarEspaciosDelTexto(txtApellido.Text);


=======
            #region 1) Preparar variables y limpiar inputs
            String strNombre = Common.eliminarEspaciosDelTexto(txtNombre.Text);
            String strApellido = Common.eliminarEspaciosDelTexto(txtApellido.Text);
            #endregion

            #region 2) Validar campos
>>>>>>> e36d4de (test "Initial commit")
            string msgDeErrores = String.Empty;
            if (!Common.esSoloLetras(strNombre)) { msgDeErrores += "\n * El nombre debe tener solo letras, por favor revisar"; }
            if (!Common.esSoloLetras(strApellido)) { msgDeErrores += "\n * El apellido debe tener solo letras, por favor revisar"; }
            if (string.IsNullOrEmpty(strNombre)) { msgDeErrores += "\n * El nombre no debe tener espacios o quedar en blanco. Por favor completar"; }
            if (string.IsNullOrEmpty(strApellido)) { msgDeErrores += "\n * El apellido no debe tener espacios o quedar en blanco. Por favor completar"; }
            if (!string.IsNullOrEmpty(msgDeErrores)) {
<<<<<<< HEAD
                mostrarMensajeEnAlerta(msgDeErrores);
                return;
            }
        }

        protected void mostrarMensajeEnAlerta(string mensaje) {
            string safeMessage = mensaje.Replace("'", "\\'").Replace("\n", "\\n");
            ClientScript.RegisterStartupScript(this.GetType(),
                "alert",
                $"alert('{safeMessage}');",
                true);
=======
                Common.mostrarMensajeEnAlerta(msgDeErrores, this);
                return;
            }
            #endregion
>>>>>>> e36d4de (test "Initial commit")
        }
    }
}
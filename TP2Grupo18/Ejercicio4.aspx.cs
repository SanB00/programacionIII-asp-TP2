using System;

namespace TP2Grupo18
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        protected void btnValidar_Click(object sender, EventArgs e) {
            // Al ser "usuario/clave" no es necesario modificar eliminando los espacios
            string usuario = Common.eliminarEspaciosDelTexto(txtUsuario.Text);
            string clave = txtClave.Text.Trim();

            if (usuario.ToLower() == "claudio" && clave == "casas") {
                Response.Redirect("Ejercicio4Valido.aspx?usuario=" + usuario); //Server.Transfer("Ejercicio4Valido.aspx");
            }
            else {
                Server.Transfer("Ejercicio4Error.aspx");
            }
        }
    }
}
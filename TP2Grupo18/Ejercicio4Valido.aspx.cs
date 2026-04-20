using System;

namespace TP2Grupo18
{
    public partial class Ejercicio4Valido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            string nombreRecibido = obtenerUsuarioConQueryParam();
            lblBienvenida.Text = "Bienvenido a mi página Sr./a " + nombreRecibido;
        }

        protected string obtenerUsuarioConServerTransfer() {
            string nombre;

            nombre = Request["txtUsuario"].ToString();

            return nombre;
        }
        protected string obtenerUsuarioConQueryParam() {
            return Request.QueryString["usuario"].ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupo18
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text.Trim().ToLower();
            string clave = txtClave.Text.Trim();

            if (usuario == "claudio" && clave == "casas") {
                Response.Redirect("WebForm2.aspx?usuario=" + usuario);
            }
            else {
            }
        }
    }
}
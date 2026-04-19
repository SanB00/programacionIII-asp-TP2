using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupo18
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            string nombre = Request["txtNombre"].ToString();
            string apellido = Request["txtApellido"].ToString();
            string zona = Session["Zona"] != null ? Session["Zona"].ToString() : "Sin zona";
            string temas = Session["Temas"] != null ? Session["Temas"].ToString() : "Sin Temas";

            lblNombre.Text = "Nombre: " + nombre;
            lblApellido.Text = "Apellido: " + apellido;
            lblZona.Text = "Zona: " + zona;
            lblTemasElegidos.Text = "Temas: " + temas;

            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            int hora = DateTime.Now.Hour;
            if (hora < 12) {
                lblMensaje.Text = "¡Buen día! El resumen se generó correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            else {
                lblMensaje.Text = "¡Buenas tardes! El resumen se generó correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Blue;
            }


        }
    }
}
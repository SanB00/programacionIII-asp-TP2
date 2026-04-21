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
            string nombre = Request["txtNombre"] != null ? Request["txtNombre"].ToString() : "Sin nombre";
            string apellido = Request["txtApellido"] != null ? Request["txtApellido"].ToString() : "Sin apellido";
            string zona = Session["Zona"] != null ? Session["Zona"].ToString() : "Sin zona";
            string ciudad = Session["Ciudad"] != null ? Session["Ciudad"].ToString() : "Sin ciudad";
            string temas = Session["Temas"] != null ? Session["Temas"].ToString() : "Sin temas seleccionados";

            lblNombre.Text = "Nombre: " + nombre;
            lblApellido.Text = "Apellido: " + apellido;
            lblZona.Text = $"Zona: {zona} ({ciudad})";
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
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }
    }
}
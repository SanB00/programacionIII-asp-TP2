using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupo18
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void lbtnVerde_Click(object sender, EventArgs e) {
            lblTexto.ForeColor = System.Drawing.Color.Green;
            int contVerde = (ViewState["ContVerde"] != null) ? (int)ViewState["ContVerde"] : 0;
            contVerde++;
            ViewState["ContVerde"] = contVerde;
            lblContVerde.Text = "Verdes: " + contVerde;
        }
        protected void lbtnAzul_Click(object sender, EventArgs e) {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
        }

        protected void lbtnAmarillo_Click(object sender, EventArgs e) {
            lblTexto.ForeColor = System.Drawing.Color.Yellow;
        }
        protected void lbtnRojo_Click(object sender, EventArgs e) {
            lblTexto.ForeColor = System.Drawing.Color.Red;
        }

        static Random rnd = new Random();
        protected void lbtnRandom_Click(object sender, EventArgs e) {
            int index = rnd.Next(3);

            switch (index) {
                case 0:
                    lblTexto.ForeColor = System.Drawing.Color.Green;
                    lblTexto.Text = "Testo Coloreado a color Verde";
                    break;
                case 1:
                    lblTexto.ForeColor = System.Drawing.Color.Blue;
                    lblTexto.Text = "Texto coloreado a color Azul";
                    break;
                case 2:
                    lblTexto.ForeColor = System.Drawing.Color.Yellow;
                    lblTexto.Text = "Texto Coloreado a Color Amarillo";
                    break;
                case 3:
                    lblTexto.ForeColor = System.Drawing.Color.Red;
                    lblTexto.Text = "Texto Coloreado a Color Rojo";
                    break;
            }
        }

        protected void btnCambiarTexto_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(txtNuevoTexto.Text)) {
                lblTexto.Text = txtNuevoTexto.Text;
                txtNuevoTexto.Text = "";
            }
            else {
                lblTexto.Text = "¡Error! Por favor, ingresá un texto.";
                lblTexto.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
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
        private void incrementarContadorColor(string color) {
            int cantColor = (ViewState[color] != null) ? (int)ViewState[color] + 1 : 0;
            ViewState[color] = cantColor;

        }
        protected void lbtnVerde_Click(object sender, EventArgs e) {
            System.Drawing.Color color = System.Drawing.Color.Green;
            lblTexto.ForeColor = color;
            incrementarContadorColor(color.ToString());
            lblContVerde.Text = "Verdes: " + ViewState[color.ToString()];
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

        protected void lbtnRandom_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            int index = rnd.Next(3);

            switch (index) {
                case 0:
                    lblTexto.ForeColor = System.Drawing.Color.Green;
                    lblTexto.Text = "Texto coloreado a color Verde";
                    lbtnVerde_Click(this, e);
                    break;
                case 1:
                    lblTexto.ForeColor = System.Drawing.Color.Blue;
                    lblTexto.Text = "Texto coloreado a color Azul";
                    break;
                case 2:
                    lblTexto.ForeColor = System.Drawing.Color.Yellow;
                    lblTexto.Text = "Texto coloreado a color Amarillo";
                    break;
                case 3:
                    lblTexto.ForeColor = System.Drawing.Color.Red;
                    lblTexto.Text = "Texto coloreado a color Rojo";
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
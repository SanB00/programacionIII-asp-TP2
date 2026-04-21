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
            string nombreColor = "Verde";
            actualizarTextoLinkButton(sender, System.Drawing.Color.Green, nombreColor);
            lblTexto.Text = $"Texto coloreado a color {nombreColor}";
        }
        protected void lbtnAzul_Click(object sender, EventArgs e) {
            string nombreColor = "Azul";
            actualizarTextoLinkButton(sender, System.Drawing.Color.Blue, nombreColor);
            lblTexto.Text = $"Texto coloreado a color {nombreColor}";
        }

        protected void lbtnAmarillo_Click(object sender, EventArgs e) {
            string nombreColor = "Amarillo";
            actualizarTextoLinkButton(sender, System.Drawing.Color.Yellow, nombreColor);
            lblTexto.Text = $"Texto coloreado a color {nombreColor}";
        }
        protected void lbtnRojo_Click(object sender, EventArgs e) {
            string nombreColor = "Rojo";
            actualizarTextoLinkButton(sender, System.Drawing.Color.Red, nombreColor);
            lblTexto.Text = $"Texto coloreado a color {nombreColor}";
        }

        private int incrementarContadorColor(string color) {
            int cantColor = (ViewState[color] != null) ? (int)ViewState[color] + 1 : 1;
            ViewState[color] = cantColor;
            return cantColor;
        }

        private void actualizarTextoLinkButton(object sender, System.Drawing.Color color, string nombreColor) {
            lblTexto.ForeColor = color;
            int newQuantity = incrementarContadorColor(color.ToString());
            LinkButton btn = sender as LinkButton;
            btn.Text = $"({newQuantity}) {nombreColor}";
        }

        protected void lbtnRandom_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            int index = rnd.Next(3);

            switch (index) {
                case 0:
                    lbtnVerde_Click(lbtnVerde, e);
                    break;
                case 1:
                    lbtnAzul_Click(lbtnAzul, e);
                    break;
                case 2:
                    lbtnAmarillo_Click(lbtnAmarillo, e);
                    break;
                case 3:
                    lbtnRojo_Click(lbtnRojo, e);
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

        protected void btnVolver_Click(object sender, EventArgs e) {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}
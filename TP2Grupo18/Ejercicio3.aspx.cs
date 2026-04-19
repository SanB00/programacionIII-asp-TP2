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
                    break;
                case 1:
                    lblTexto.ForeColor = System.Drawing.Color.Blue;
                    break;
                case 2:
                    lblTexto.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case 3:
                    lblTexto.ForeColor = System.Drawing.Color.Red;
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
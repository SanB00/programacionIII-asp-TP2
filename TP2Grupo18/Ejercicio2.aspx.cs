using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace TP2Grupo18
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnVerResumen_Click(object sender, EventArgs e) {
            String strNombre = Common.eliminarEspaciosDelTexto(txtNombre.Text);
            String strApellido = Common.eliminarEspaciosDelTexto(txtApellido.Text);
            string msgDeErrores = String.Empty;
            if (strNombre.Length < 2) { msgDeErrores += "\n * El nombre es demasiado corto."; }
            if (!Common.esSoloLetras(strNombre)) { msgDeErrores += "\n * El nombre debe tener solo letras, por favor revisar"; }
            if (!Common.esSoloLetras(strApellido)) { msgDeErrores += "\n * El apellido debe tener solo letras, por favor revisar"; }
            if (string.IsNullOrEmpty(strNombre)) { msgDeErrores += "\n * El nombre no debe tener espacios o quedar en blanco. Por favor completar"; }
            if (string.IsNullOrEmpty(strApellido)) { msgDeErrores += "\n * El apellido no debe tener espacios o quedar en blanco. Por favor completar"; }
            if (!string.IsNullOrEmpty(msgDeErrores)) {
                Common.mostrarMensajeEnAlerta(msgDeErrores, this);
                return;
            }
            #region Obtención de temas seleccionados
            List<string> listaTemas = new List<string>();
            foreach (ListItem item in chkTemas.Items) {
                if (item.Selected) {
                    listaTemas.Add(item.Text);
                }
            }
            string temasSeleccionados = string.Join(", ", listaTemas);
            if (string.IsNullOrEmpty(temasSeleccionados)) {
                temasSeleccionados = "Ninguno";
            }
            #endregion

            Session["Nombre"] = strNombre;
            Session["Apellido"] = strApellido;
            Session["Temas"] = temasSeleccionados;
            Session["Zona"] = ddlCiudades.SelectedValue;
            Session["Ciudad"] = ddlCiudades.SelectedItem.Text;
            Server.Transfer("Ejercicio2Form2.aspx");
        }
    }
}
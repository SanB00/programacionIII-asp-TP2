using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace TP2Grupo18
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                cargarDdlCantMemoria(); // Solo se ejecuta la primera vez
                chkAccesorios.Items.Add(new ListItem("Monitor LCD", "2000.50"));
                chkAccesorios.Items.Add(new ListItem("HD 500GB", "550.50"));
                chkAccesorios.Items.Add(new ListItem("Grabador DVD", "1200"));
            }
        }

        private void cargarDdlCantMemoria() {
            var listData = new[] {
                new { Key = "2 GB", Value = 200 },
                new { Key = "4 GB", Value = 375 },
                new { Key = "6 GB", Value = 500 }
            };
            ddlCantMemoria.DataSource = listData;
            ddlCantMemoria.DataValueField = "Value";
            ddlCantMemoria.DataTextField = "Key";
            ddlCantMemoria.DataBind();
        }

        protected void btnCalcularPrecio_Click(object sender, EventArgs e) {
            String memoriaSeleccionada = ddlCantMemoria.SelectedItem.Text;
            int precioMemoria = int.Parse(ddlCantMemoria.SelectedValue);

            float precioAccesorios = 0.0f;
            float precioFinal = precioMemoria + precioAccesorios;
            lblResultado.Text = $"El precio de la memoria RAM de {memoriaSeleccionada} es ${precioMemoria}. El precio Total es {precioFinal:F2}";

        }
    }
}
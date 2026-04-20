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

            if (rblProcesador.SelectedIndex == -1 || rblAlmacenamiento.SelectedIndex == -1)
            {
                lblResultado.Text = "<span style='color:red;'>Por favor seleccioná un procesador y un almacenamiento.</span>";
                return;
            }

            String memoriaSeleccionada = ddlCantMemoria.SelectedItem.Text;
            int precioMemoria = int.Parse(ddlCantMemoria.SelectedValue);
            string nombreProcesador = rblProcesador.SelectedItem.Text;
            int precioProcesador = int.Parse(rblProcesador.SelectedValue);
            string nombreDisco = rblAlmacenamiento.SelectedItem.Text;
            int precioDisco = int.Parse(rblAlmacenamiento.SelectedValue);
            
            if (chbDualChannel.Checked)
            {
                precioMemoria = precioMemoria * 2;
                memoriaSeleccionada = memoriaSeleccionada + " (x2 Dual Channel)";
            }

            float precioAccesorios = 0.0f;

            foreach (ListItem item in chkAccesorios.Items)
            {
                if (item.Selected)
                {
                    precioAccesorios += float.Parse(item.Value, System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            float precioFinal = precioMemoria + precioAccesorios + precioDisco + precioProcesador;
            lblResultado.Text = $"Memoria RAM {memoriaSeleccionada}: ${precioMemoria:F2}. <br />" + 
                      $"Procesador {nombreProcesador}: ${precioProcesador:F2}. <br />" +
                      $"Accesorios: ${precioAccesorios}. <br />" +
                      $"Disco {nombreDisco}: ${precioDisco:F2}. <br />" +
                      $"<strong>El precio Total es: ${precioFinal:F2}</strong>";

        }
    }
}
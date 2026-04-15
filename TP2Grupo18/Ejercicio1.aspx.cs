using System;
using System.Data;

namespace TP2Grupo18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnGenerarTabla_Click(object sender, EventArgs e) {
            string msgDeErrores = String.Empty;

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] {
                new DataColumn("Producto", typeof(string)),
                new DataColumn("Cantidad", typeof(int))
            });
            String strCantidad1 = Common.eliminarEspaciosDelTexto(txtCantidad1.Text);
            String strCantidad2 = Common.eliminarEspaciosDelTexto(txtCantidad2.Text);

            String strProducto1 = Common.eliminarEspaciosDelTexto(txtProducto1.Text);
            String strProducto2 = Common.eliminarEspaciosDelTexto(txtProducto2.Text);

            if (!Common.esUnNroValido(strCantidad1)) { msgDeErrores += "\n * Ingrese números válidos y mayores a 0 para el producto 1"; }
            if (!Common.esUnNroValido(strCantidad2)) { msgDeErrores += "\n * Ingrese números válidos y mayores a 0 para el producto 2"; }
            if (!Common.esSoloLetras(strProducto1) || string.IsNullOrEmpty(strProducto1)) { msgDeErrores += "\n * Ingrese un producto válido sin números. Revisar producto 1"; }
            if (!Common.esSoloLetras(strProducto2) || string.IsNullOrEmpty(strProducto2)) { msgDeErrores += "\n * Ingrese un producto válido sin números. Revisar producto 2"; }
            if (!string.IsNullOrEmpty(msgDeErrores)) { mostrarMensajeEnAlerta(msgDeErrores); return; }

            int cantidad1 = string.IsNullOrEmpty(strCantidad1) ? 0 : int.Parse(strCantidad1);
            int cantidad2 = string.IsNullOrEmpty(strCantidad2) ? 0 : int.Parse(strCantidad2);
            dt.Rows.Add(strProducto1, cantidad1);
            dt.Rows.Add(strProducto2, cantidad2);
            int resultadoTotal = cantidad1 + cantidad2;
            dt.Rows.Add("TOTAL", resultadoTotal.ToString());

            gvListadoProductos.DataSource = dt;
            gvListadoProductos.DataBind();
        }

        protected void mostrarMensajeEnAlerta(string mensaje) {
            string safeMessage = mensaje.Replace("'", "\\'").Replace("\n", "\\n");
            ClientScript.RegisterStartupScript(this.GetType(),
                "alert",
                $"alert('{safeMessage}');",
                true);

        }
    }
}
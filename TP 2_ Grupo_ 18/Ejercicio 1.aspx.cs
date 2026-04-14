using System;
using System.Data;

namespace TP2Grupo18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnGenerarTabla_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] {
                new DataColumn("Producto", typeof(string)),
                new DataColumn("Cantidad", typeof(int))
            });
            String strCantidad1 = Common.eliminarEspaciosDelTexto(txtCantidad1.Text);
            String strCantidad2 = Common.eliminarEspaciosDelTexto(txtCantidad2.Text);

            int cantidad1 = string.IsNullOrEmpty(strCantidad1) ? 0 : int.Parse(strCantidad1);
            int cantidad2 = string.IsNullOrEmpty(strCantidad2) ? 0 : int.Parse(strCantidad2);

            dt.Rows.Add(txtProducto1.Text, cantidad1);
            dt.Rows.Add(txtProducto2.Text, cantidad2);

            int resultadoTotal = cantidad1 + cantidad2;
            dt.Rows.Add("TOTAL", resultadoTotal.ToString());

            gvListadoProductos.DataSource = dt;
            gvListadoProductos.DataBind();
        }
    }
}
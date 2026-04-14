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
                new DataColumn("Cantidad", typeof(int))}
       );
            String cantidad1 = txtCantidad1.Text;
            String cantidad2 = txtCantidad2.Text;
            dt.Rows.Add(txtProducto1.Text, cantidad1);
            dt.Rows.Add(txtProducto2.Text, cantidad2);

            int resultadoTotal = int.Parse(cantidad1) + int.Parse(cantidad2);
            dt.Rows.Add("TOTAL", resultadoTotal.ToString());

            gvListadoProductos.DataSource = dt;
            gvListadoProductos.DataBind();
        }
    }
}
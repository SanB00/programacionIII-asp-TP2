using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupo18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            tblProductos.Rows.Clear();

            TableRow filaHeader = new TableRow();
            filaHeader.Cells.Add(new TableCell { Text = "Producto" });
            filaHeader.Cells.Add(new TableCell { Text = "Cantidad" });
            tblProductos.Rows.Add(filaHeader);

            String producto1 = txtProducto1.Text;
            String cantidad1 = txtCantidad1.Text;
            TableRow fila = new TableRow();
            fila.Cells.Add(new TableCell { Text = producto1 });
            fila.Cells.Add(new TableCell { Text = cantidad1 });
            tblProductos.Rows.Add(fila);


            String producto2 = txtProducto2.Text;
            String cantidad2 = txtCantidad2.Text;
            TableRow fila2 = new TableRow();
            fila2.Cells.Add(new TableCell { Text = producto2 });
            fila2.Cells.Add(new TableCell { Text = cantidad2 });
            tblProductos.Rows.Add(fila2);

            int resultadoTotal = int.Parse(cantidad1) + int.Parse(cantidad2);
            TableRow fila3 = new TableRow();
            fila3.Cells.Add(new TableCell { Text = "TOTAL" });
            fila3.Cells.Add(new TableCell { Text = resultadoTotal.ToString() });
            tblProductos.Rows.Add(fila3);
        }
    }
}
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTabla_Click(object sender, EventArgs e)
        {
            TblProductos.Rows.Clear();

            TableRow filaHeader = new TableRow();
            filaHeader.Cells.Add(new TableCell { Text = "Producto" });
            filaHeader.Cells.Add(new TableCell { Text = "Cantidad" });
            TblProductos.Rows.Add(filaHeader);


            String producto = txtProducto.Text;
            String cantidad = txtCantidad.Text;

            TableRow fila = new TableRow();
            fila.Cells.Add(new TableCell { Text = producto });
            fila.Cells.Add(new TableCell { Text = cantidad });
            TblProductos.Rows.Add(fila);


            String producto2 = txtProducto2.Text;
            String cantidad2 = txtCantidad2.Text;

            TableRow fila2 = new TableRow();
            fila2.Cells.Add(new TableCell { Text = producto2 });
            fila2.Cells.Add(new TableCell { Text = cantidad2 });
            TblProductos.Rows.Add(fila2);
        }
    }
}
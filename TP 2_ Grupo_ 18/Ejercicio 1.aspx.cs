using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2__Grupo__18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnTabla_Click(object sender, EventArgs e)
        {
            TblProductos.Rows.Clear();

            TableRow filaHeader = new TableRow();
            filaHeader.Cells.Add(new TableCell { Text = "Producto" });
            filaHeader.Cells.Add(new TableCell { Text = "Cantidad" });
            TblProductos.Rows.Add(filaHeader);

            
           


        }
    }
}
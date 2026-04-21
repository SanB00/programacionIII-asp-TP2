using System;

namespace TP2Grupo18
{
    public partial class Ejercicio4Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void linkbtnVolver_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio4.aspx");
        }
    }
}
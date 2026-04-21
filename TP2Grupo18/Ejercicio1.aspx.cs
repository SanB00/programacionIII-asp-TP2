using System;
using System.Data;

namespace TP2Grupo18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnGenerarTabla_Click(object sender, EventArgs e) {
            #region 1) Preparar variables y limpiar inputs
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
            #endregion

            #region 2) Validar campos
            if (!Common.esUnNroValido(strCantidad1)) { msgDeErrores += "\n * Ingrese números válidos y mayores a 0 para el producto 1"; }
            if (!Common.esUnNroValido(strCantidad2)) { msgDeErrores += "\n * Ingrese números válidos y mayores a 0 para el producto 2"; }
            if (!Common.esSoloLetras(strProducto1)) { msgDeErrores += "\n * Ingrese un producto válido sin números. Revisar producto 1"; }
            if (!Common.esSoloLetras(strProducto2)) { msgDeErrores += "\n * Ingrese un producto válido sin números. Revisar producto 2"; }
            if (string.IsNullOrEmpty(strProducto1)) { msgDeErrores += "\n * El producto 1 no debe tener espacios o quedar en blanco."; }
            if (string.IsNullOrEmpty(strProducto2)) { msgDeErrores += "\n * El producto 2 no debe tener espacios o quedar en blanco."; }
            if (!Common.estaElTextoDentroDelRango(strProducto1)) { msgDeErrores += $"\n * El Producto 1 debe tener entre {Common.MIN_CHARS_TEXTO} y {Common.MAX_CHARS_TEXTO} caracteres."; }
            if (!Common.estaElTextoDentroDelRango(strProducto2)) { msgDeErrores += $"\n * El Producto 2 debe tener entre {Common.MIN_CHARS_TEXTO} y {Common.MAX_CHARS_TEXTO} caracteres."; }
            if (strProducto1.ToLower() == strProducto2.ToLower()) { msgDeErrores += "\n * El producto no debe repetirse."; }

            if (!string.IsNullOrEmpty(msgDeErrores)) {
                Common.mostrarMensajeEnAlerta(msgDeErrores, this);
                return;
            }
            #endregion

            #region 3) Cargar tabla
            int cantidad1 = string.IsNullOrEmpty(strCantidad1) ? 0 : int.Parse(strCantidad1);
            int cantidad2 = string.IsNullOrEmpty(strCantidad2) ? 0 : int.Parse(strCantidad2);
            dt.Rows.Add(strProducto1, cantidad1);
            dt.Rows.Add(strProducto2, cantidad2);
            int resultadoTotal = cantidad1 + cantidad2;
            dt.Rows.Add("TOTAL", resultadoTotal.ToString());

            gvListadoProductos.DataSource = dt;
            gvListadoProductos.DataBind();
            #endregion

            #region 4) Limpiar campos después de cargar la tabla
            this.btnLimpiar_Click(this, e);
            #endregion
        }

        protected void btnLimpiar_Click(object sender, EventArgs e) {
            txtCantidad1.Text = string.Empty;
            txtCantidad2.Text = string.Empty;
            txtProducto1.Text = string.Empty;
            txtProducto2.Text = string.Empty;
        }
    protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vista.carrito;

namespace Vista.web.carrito
{
    public partial class CarroDeCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                 
                     if (!IsPostBack)
                     BindData();
             }
             protected void BindData()
             {
                 gvCaritoCompras.DataSource = Carrodecompra.CapturarProducto().ListaProductos;
                 gvCaritoCompras.DataBind();
             }
       /*     protected void gvCaritoCompras_RowDataBound(object sender, GridViewRowEventArgs e)
             {
                 if (e.Row.RowType == DataControlRowType.Footer)
                 {
                     e.Row.Cells[3].Text = “Total: “ + CarroDeCompras.CapturarProducto().SubTotal().ToString(“C”);
                 }
             } */
             protected void gvCaritoCompras_RowCommand(object sender, GridViewCommandEventArgs e)
             {
                 if (e.CommandName == "Eliminar")
                 {
                     string pCodigo = Convert.ToString(e.CommandArgument);
                     Carrodecompra.CapturarProducto().EliminarProductos(pCodigo);
                 }   
                 BindData();
             }
             protected void btActulizar_Click(object sender, EventArgs e)
             {
                 foreach (GridViewRow row in gvCaritoCompras.Rows)
                 {
                     if (row.RowType == DataControlRowType.DataRow)
                     {
                         try
                         {
                             string pCodigo = Convert.ToString(gvCaritoCompras.DataKeys[row.RowIndex].Value);

//gvCaritoCompras.DataKeys[row.RowIndex].Value;
                             
//int cantidad = int.Parse(((TextBox)row.Cells[1].FindControl(“txtCantidad”)).Text);
                             int cantidad = Convert.ToInt32((Label)row.Cells[1].FindControl("lblCantidad"));
                             Carrodecompra.CapturarProducto().CantidadDeProductos(pCodigo, cantidad);
 //CarroDeCompras.CapturarProducto().CantidadDeProductos(productoId, cantidad);
                         }
                         catch (FormatException) { }
                     }
                 }
                 BindData();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Vista.web.pagar
{
    public partial class portalPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si la sesión es válida y contiene ítems en carrito
            if (Session["Usuario"] != null)
            {
                var _cadenaEntradas = ((carritoClase.CarroDeCompras)Session["Carrito"]).obtenerCodigos();
                var _entradas = JArray.Parse(new Servicio.ControladorServicioClient().RecuperarEntradas(_cadenaEntradas));
                var _dt = new System.Data.DataTable();
                _dt.Columns.Add("Codigo");
                _dt.Columns.Add("Evento");
                _dt.Columns.Add("Precio");


                var _total = 0;
                foreach (JObject entrada in _entradas)
                {
                    DataRow newRow = _dt.NewRow();
                    newRow[0] = entrada["Codigo"];
                    newRow[1] = JObject.Parse(entrada["Evento"].ToString())["Nombre"];
                    newRow[2] = entrada["Precio"];
                    _dt.Rows.Add(newRow);

                    _total += Convert.ToInt32(entrada["Precio"].ToString());
                }

                DataRow precioRow = _dt.NewRow();
                precioRow[1] = "Total";
                precioRow[2] = "$" + _total;

                _dt.Rows.Add(precioRow);
                gridViewEntradas.DataSource = _dt;
                gridViewEntradas.DataBind();
            }
        }


        protected void btnConfimarCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Collections;


namespace Vista.web.catalogo
{
    public partial class CatalogoEvento : System.Web.UI.Page
    {
        string valor = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var _resultado = JArray.Parse(new Servicio.ControladorServicioClient().ListarEventos_Activos().ToString());


            //       var name = (string)_resultado[0]["Codigo"];

            if (_resultado != null)
            {
                valor = (string)_resultado[0]["Codigo"];
                Label2.Text = (string)_resultado[0]["Nombre"];
                Label5.Text = (string)_resultado[0]["Fecha"];
                Label7.Text = (string)_resultado[0]["Recinto"]["Nombre"];
                valor = (string)_resultado[1]["Codigo"];
                Label1.Text = (string)_resultado[1]["Nombre"];
                Label9.Text = (string)_resultado[1]["Fecha"];
                Label11.Text = (string)_resultado[1]["Recinto"]["Nombre"];
                valor = (string)_resultado[2]["Codigo"];
                Label12.Text = (string)_resultado[2]["Nombre"];
                Label14.Text = (string)_resultado[2]["Fecha"];
                Label16.Text = (string)_resultado[2]["Recinto"]["Nombre"];
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                // derivar a detalle
                Response.Redirect("/web/Catalogo/Detalle.aspx" + "?" + "codigo=" + valor);
            }
            else
            {
                Server.Transfer("/Login.aspx");
            }
            /*
            lblModalTitle.Text = "Validation Errors List for HP7 Citation";
            lblModalBody.Text = "This is modal body";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
             * */
        }        
    }
}
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
using Vista.carrito;


namespace Vista.web.catalogo
{
    public partial class CatalogoEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nombre = "LOGIN";
            Session["nombre"] = nombre;


            if (nombre == null)
            {
                Session["lOGIN"] = nombre;
            } 

            DataTable dt = new DataTable();
            var _resultado = JArray.Parse(new Servicio.ControladorServicioClient().ListarEventos_Activos().ToString());

            
     //       var name = (string)_resultado[0]["Codigo"];

            if (_resultado != null)
            {
                foreach (JObject item in _resultado)
                {
                     Label3.Text = _resultado[0].ToString();
                     if (_resultado[0].ToString() != null)
                     {
                         Label18.Text = (string)_resultado[0]["Codigo"];
                         Label2.Text = (string)_resultado[0]["Nombre"];
                         Label5.Text = (string)_resultado[0]["Fecha"];
                         Label7.Text = (string)_resultado[0]["Recinto"]["Nombre"];
                     }
                     if (_resultado[1].ToString() != null)
                         {

                             Label1.Text = (string)_resultado[1]["Nombre"];
                             Label9.Text = (string)_resultado[1]["Fecha"];
                             Label11.Text = (string)_resultado[1]["Recinto"]["Nombre"];
                         }
                     if (_resultado[2].ToString() != null)
                     {

                         Label12.Text = (string)_resultado[2]["Nombre"];
                         Label14.Text = (string)_resultado[2]["Fecha"];
                         Label16.Text = (string)_resultado[2]["Recinto"]["Nombre"];
                     }                     
                }
            }
            else
            {
                //mensaje de error;
            }


            


   /*         DataTable dt = new DataTable();
            this._eventos = new Evento();
            

            

        //    DataTable dat = new Evento().ListarEventosActivos().ToString();
         //   DataTable dt = (DataTable)JsonConvert.DeserializeObject(dat,typeof(DataTable));


            /*
             * var _evento = new Evento();
            var _dat = _evento.ListarEventosActivos().AsEnumerable().ToList();
            
             * 
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Evento ev = new Evento();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fecha Evento");

            DataRow row = dt.NewRow();
            row["Id"] = 1;
            row["Nombre"] = ev.Nombre;
            row["Fecha Evento"] = ev.Fecha;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 2;
            row["Nombre"] = "Federico";
            row["Fecha Evento"] = "PM";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 3;
            row["Nombre"] = "Leonardo";
            row["Fecha Evento"] = "Developer";
            dt.Rows.Add(row);

            return dt; */
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblModalTitle.Text = "Validation Errors List for HP7 Citation";
            lblModalBody.Text = "This is modal body";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
        protected void btnComEntrada_Click(object sender, EventArgs e)
        {

            Carrodecompra carrito = Carrodecompra.CapturarProducto();
           string pCodigo = Label8.ToString();
            carrito.Agregar(pCodigo);
        
        } 
    
        
    }
}
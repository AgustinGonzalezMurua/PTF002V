using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;

namespace Vista
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
             var _resultado = JObject.Parse(new Servicio.ControladorServicioClient().ValidarUsuario(txtUsuario.Text, txtClave.Text));
             if (Convert.ToBoolean(_resultado["Salida"].ToString()))
             {
                 Response.Write("<script>window.alert('Bienvenido');</script>");
                 Server.Transfer("Home.aspx", true);
             }
             else
             {
                 Response.Write("<script>window.alert('El usuario o contraseña no coinciden');</script>"); 
             }
 
        }
    }
}
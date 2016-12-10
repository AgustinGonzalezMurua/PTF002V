using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using System.Text;


namespace Vista
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          string nombre = "LOGIN";
            Session["nombre"]= nombre;

      
            if (nombre == null)
            {
                Session["lOGIN"] = nombre;
            } 
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            #region SerializacionMD5
            var md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputHash = System.Text.Encoding.ASCII.GetBytes(txtClave.Text);
            byte[] hash = md5.ComputeHash(inputHash);
            StringBuilder pass = new StringBuilder();
            foreach (var b in hash)
            {
                pass.Append(b.ToString("X2"));
            }
            #endregion

            var _resultado = JObject.Parse(new Servicio.ControladorServicioClient().ValidarUsuario(txtUsuario.Text, pass.ToString()));
            if (Convert.ToBoolean(_resultado["Respuesta"].ToString()))
            {
                Response.Write("<script>window.alert('Bienvenido');</script>");
                Server.Transfer("/Home.aspx", true);
            }
            else
            {
                Response.Write("<script>window.alert('El usuario o contraseña no coinciden');</script>"); 
            }
        }
    }
}
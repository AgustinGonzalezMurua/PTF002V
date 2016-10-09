using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Vista
{
    public partial class TestLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BotonLogin_Click(object sender, EventArgs e)
        {
            var _resultado = JObject.Parse(new Servicio.ControladorServicioClient().ValidarUsuario(TextUsuario.Text, TextContraseña.Text));
            if (Convert.ToBoolean(_resultado["Salida"].ToString()))
            {
                var _usuario = JObject.Parse(new Servicio.ControladorServicioClient().RecuperarUsuario(TextUsuario.Text));
                LabelUsuarioNombre.Text = _usuario["Nombre"].ToString();
                LabelUsuarioFono.Text = _usuario["Fono"].ToString();
                LabelUsuarioEmail.Text = _usuario["Email"].ToString();

            }
        }
    }
}
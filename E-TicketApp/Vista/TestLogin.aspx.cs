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
            LabelNotificacion.Text = (string)_resultado["Salida"];
        }
    }
}
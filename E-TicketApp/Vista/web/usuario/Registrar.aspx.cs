using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using Servicio;
using Newtonsoft.Json;
using System.Text;

namespace Vista
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            var _usuarioJson = new JObject();
            _usuarioJson.Add("Nombre", txtNombre.Text);
            _usuarioJson.Add("Run", txtRut.Text);
            _usuarioJson.Add("Fono", txtTelefono.Text);
            _usuarioJson.Add("Correo", txtCorreo.Text);
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
            _usuarioJson.Add("Contrasegna", pass.ToString());

            var _resultado = JObject.Parse(new Servicio.ControladorServicioClient().RegistrarUsuario((_usuarioJson).ToString(Formatting.Indented)));

            //redireccionar.-
            Server.Transfer("/Home.aspx", true);
        }

        }
    }
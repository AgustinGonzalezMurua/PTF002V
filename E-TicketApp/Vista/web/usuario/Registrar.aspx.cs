using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Net.Mail;
using System.Net;

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

             System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
             msg.To.Add(txtCorreo.Text);
            msg.From = new MailAddress("katherine.93824736@gmail.com", "Tu Nombre", System.Text.Encoding.UTF8);
            msg.Subject = "Prueba de correo a GMail";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Cuerpo del mensaje";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false; 

            //Aquí es donde se hace lo especial
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("katherine.93824736@gmail.com",".anibal.");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                        Response.Write("<script>window.alert('Registrado');</script>");
                        client.Send(msg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
            }


            //redireccionar.-
            Server.Transfer("/Home.aspx", true);
        }

        }
    }
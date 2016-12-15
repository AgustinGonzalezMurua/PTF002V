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

            try
            {
                var _usuarioJson = new JObject();
                _usuarioJson.Add("Nombre", txtNombre.Text);
                _usuarioJson.Add("RUN", txtRut.Text);
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

                JObject _resultado = JObject.Parse(new Servicio.ControladorServicioClient().RegistrarUsuario((_usuarioJson).ToString(Formatting.Indented), pass.ToString()));


                if (_resultado["Error"] != null)
                {
                    throw new ArgumentException(_resultado["Error"].ToString());
                }
                else
                {
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                    msg.To.Add(txtCorreo.Text);
                    msg.From = new MailAddress("eticketpf@gmail.com", "Tu Nombre", System.Text.Encoding.UTF8);
                    msg.Subject = "Prueba de correo a GMail";
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;
                    msg.Body = "Cuerpo del mensaje";
                    msg.BodyEncoding = System.Text.Encoding.UTF8;
                    msg.IsBodyHtml = false;

                    //Aquí es donde se hace lo especial
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("eticketpf@gmail.com", "eticket123");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail

                    Response.Write("<script>window.alert('Registrado');</script>");
                    client.Send(msg);
                    Server.Transfer("/Home.aspx", true);
                }
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                var message = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(ex.Message.ToString());
                var script = string.Format("alert({0});", message);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", script, true);
            }

        }

        }
    }
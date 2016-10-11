﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using Servicio;
using Newtonsoft.Json;

namespace Vista
{
    public partial class AgregarCliente1 : System.Web.UI.Page
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
                _usuarioJson.Add("Contrasegna", txtClave.Text);

                var _resultado = JObject.Parse(new Servicio.ControladorServicioClient().RegistrarUsuario((_usuarioJson).ToString(Formatting.Indented)));

                //redireccionar.-

                Server.Transfer("Home.aspx", true);

            }

        }
    }
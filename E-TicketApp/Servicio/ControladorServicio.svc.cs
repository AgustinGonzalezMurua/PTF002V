using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Servicio.Util;
using Newtonsoft.Json.Linq;

namespace Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class ControladorServicio : IControladorServicio
    {
        public string ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Usuario().ValidarUsuario(usuario, contrasena).ToString(), "Respuesta");
            }
            catch (Exception)
            {
                return SerializadorJSON.Serializar(false, "Respuesta"); ;
            }
        }


        public string RecuperarUsuario(string run)
        {
            try
            {
                var _usuario = new Negocio.Usuario();
                _usuario.RUN = run;
                _usuario.Recuperar(); 
                return SerializadorJSON.Serializar(_usuario);
            }
            catch (Exception)
            {
                
                throw;
            }
        }



        public string RegistrarUsuario(string usuario)
        {
            try
            {
                var _usuarioJson = JObject.Parse(usuario);
                var _usuario = new Negocio.Usuario();
                _usuario.Nombre = _usuarioJson["Nombre"].ToString();
                _usuario.RUN = _usuarioJson["Run"].ToString();
                _usuario.Fono = _usuarioJson["Fono"].ToString();
                _usuario.Email = _usuarioJson["Correo"].ToString();
                if (Util.ValidadorDatos.ValidarCadena(_usuarioJson["Contrasegna"].ToString()))
                {
                    _usuario.AgregarNuevoUsuario(_usuarioJson["Contrasegna"].ToString());
                }
                else
                {

                    // tirar mensaje .-
                }

                return SerializadorJSON.Serializar(true, "Respuesta");
            
            }
            catch (Exception)
            {
                throw;
            }
        }


        public string RegistrarUsuarioDesdeAdmin(string usuario)
        {
            try
            {
                var _usuarioJson = JObject.Parse(usuario);
                var _usuario = new Negocio.Usuario();
                _usuario.Nombre = _usuarioJson["Nombre"].ToString();
                _usuario.RUN = _usuarioJson["Run"].ToString();
                _usuario.Fono = _usuarioJson["Fono"].ToString();
                _usuario.Email = _usuarioJson["Correo"].ToString();
                _usuario.Tipo = Convert.ToInt32(_usuarioJson["Tipo"]); 
                if (Util.ValidadorDatos.ValidarCadena(_usuarioJson["Contrasegna"].ToString()))
                {
                    _usuario.AgregarNuevoUsuarioPrivilegios(_usuarioJson["Contrasegna"].ToString());
                }
                else
                {

                    // tirar mensaje .-
                }

                return SerializadorJSON.Serializar(true, "Respuesta");

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

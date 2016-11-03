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
    public class ControladorServicio : IControladorServicio
    {

        #region Usuario
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
                var _usuario = new Negocio.Usuario(run);
                return SerializadorJSON.Serializar(_usuario);
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
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
        #endregion

        #region Organizacion
        public string RecuperarOrganizacion_RUT(string rut)
        {
            try
            {
                var _organizacion = new Negocio.Organizacion(rut);
                return SerializadorJSON.Serializar(_organizacion);
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        public string RecuperarOrganizacion_RUN(string run)
        {
            try
            {
                var _organizador = new Negocio.Usuario(run);
                return SerializadorJSON.Serializar(new Negocio.Organizacion().Recuperar(_organizador));
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        #endregion

        #region Evento
        public string RecuperarEvento_Codigo(string codigo)
        {
            throw new NotImplementedException();
        }
        public string RecuperarEventos_Organizacion(string rut)
        {
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Organizacion(rut).ListarEventos());
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        public string RecuperarEventos_Ultimos50()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

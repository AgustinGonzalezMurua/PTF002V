﻿using System;
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
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Evento(codigo));
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
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
        public string RecuperarEventos_UltimosEventos()
        {
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Evento().ListarUltimosEventos());
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        public string RegistrarEvento(string evento)
        {
            try
            {
                var _eventoJson         = JObject.Parse(evento);
                var _evento             = new Negocio.Evento();
                _evento.Nombre          = _eventoJson["NOMBRE"].ToString();
                _evento.Fecha           = Convert.ToDateTime(_eventoJson["FECHA"].ToString());
                _evento.Tipo            = _eventoJson["TIPO"].ToString();
                _evento.Estado          = Convert.ToBoolean(int.Parse(_eventoJson["ESTADO"].ToString()));
                _evento.Organizacion    = new Negocio.Organizacion(_eventoJson["ORGANIZACION"].ToString());
                _evento.Recinto         = new Negocio.Recinto(int.Parse(_eventoJson["RECINTO"].ToString()));

                _evento.Agregar();

                return SerializadorJSON.Serializar(true, "Respuesta");

            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        #endregion

        #region Recinto
        public string RecuperarRecinto_Codigo(int codigo)
        {
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Recinto(codigo));
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        public string RecuperarRecinto_Todos()
        {
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Recinto().ListarRecintos());
            }
            catch (Exception ex)
            {
                return SerializadorJSON.Serializar(ex.Message, "Error");
            }
        }
        #endregion
    }
}

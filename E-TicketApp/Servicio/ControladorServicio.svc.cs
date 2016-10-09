using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Servicio.Util;

namespace Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class ControladorServicio : IControladorServicio
    {
        public string ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                return SerializadorJSON.Serializar(new Negocio.Usuario().ValidarUsuario(usuario, contrasena).ToString(),"Salida");
            }
            catch (Exception)
            {
                return SerializadorJSON.Serializar(false, "Salida"); ;
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
    }
}

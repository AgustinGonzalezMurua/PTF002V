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
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                var retorno = SerializadorJSON.Serializar(new Negocio.Usuario().ValidarUsuario(usuario, contrasena).ToString(), "Salida");
                return SerializadorJSON.Serializar(new Negocio.Usuario().ValidarUsuario(usuario, contrasena).ToString(),"Salida");
            }
            catch (Exception)
            {
                return SerializadorJSON.Serializar(false, "Salida"); ;
            }
        }
    }
}

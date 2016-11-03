﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IControladorServicio
    {

        #region Usuario
        [OperationContract]
        string ValidarUsuario(string usuario, string contrasena);

        [OperationContract]
        string RecuperarUsuario(string run);
        // TODO: Add your service operations here

        [OperationContract]
        string RegistrarUsuario(string usuario);
        //se recibe objeto Usuario

        [OperationContract]
        string RegistrarUsuarioDesdeAdmin(string usuario);
        #endregion

        #region Organizacion
        [OperationContract]
        string RecuperarOrganizacion_RUT(string rut);

        [OperationContract]
        string RecuperarOrganizacion_RUN(string run);
        #endregion

        #region Evento
        [OperationContract]
        string RecuperarEvento_Codigo(string codigo);

        [OperationContract]
        string RecuperarEventos_Organizacion(string rut);

        [OperationContract]
        string RecuperarEventos_Ultimos50();
        #endregion
    }
}

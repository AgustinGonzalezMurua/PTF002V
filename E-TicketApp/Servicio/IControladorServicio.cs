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
        [OperationContract] string ValidarUsuario(string usuario, string contrasena);
        [OperationContract] string RecuperarUsuario(string run);
        [OperationContract] string RegistrarUsuario(string usuario, string contrasena);
        [OperationContract] string RegistrarUsuarioDesdeAdmin(string usuario, string contrasena);
        [OperationContract] string ModificarUsuario(String usuario);
        [OperationContract] string EliminarUsuario(string run);
        [OperationContract] string RecuperarUsuario_Todos();
        [OperationContract] string ListarComprasUsuario(string run);
        #endregion

        #region Organizacion
        [OperationContract] string RecuperarOrganizacion_RUT(string rut);
        [OperationContract] string RecuperarOrganizacion_RUN(string rut);
        [OperationContract] string DesactivarOrganizacion(string rut);
        [OperationContract] string ModificarOrganizacion(string rut);
        #endregion

        #region Eventos
        [OperationContract] string EliminarEvento(string codigo);
        [OperationContract] string RecuperarEvento_Codigo(string codigo);
        [OperationContract] string RecuperarEventos_Organizacion(string rut);
        [OperationContract] string RecuperarEventos_UltimosEventos();
        [OperationContract] string ListarEventos_Activos();
        [OperationContract] string RegistrarEvento(string evento, int cantidadMaxima, int valor);
        [OperationContract] string ModificarEvento(string evento);
        [OperationContract] string ObtenerEvento_Precio(string codigo);
        #endregion

        #region Recinto
        [OperationContract] string RecuperarRecinto_Codigo(int codigo);
        [OperationContract] string RecuperarRecinto_Todos();
        [OperationContract] string RegistrarRecinto(string recinto);
        [OperationContract] string ModificarRecinto(string recinto);
        [OperationContract] string EliminarRecinto(int recinto);
        [OperationContract] string RegistrarUbicacion(string ubicacion);
        [OperationContract] string RecuperarUbicacion(int codigo);
        [OperationContract] string ModificarUbicacion(string ubicacion);
        [OperationContract] string EliminarUbicacion(string ubicacion);
        [OperationContract] string ListarUbicacionesPorRecinto(int recinto);
        #endregion

        #region Comuna
        [OperationContract] string ListarComunas();
        #endregion

        #region Tipos
        [OperationContract] string RecuperarTipo_Eventos();
        [OperationContract] string RecuperarTipo_Usuarios();
        #endregion

        #region Entrada
        [OperationContract] string RecuperarEntradas(string cadena);
        #endregion

        #region Compra
        [OperationContract] string RegistrarOrdenCompra(string cadena, string usuario);
        [OperationContract] string FinalizarOrdenCompra(string codigoOrdenCompra);
        #endregion
    }
}

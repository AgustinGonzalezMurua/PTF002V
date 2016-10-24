using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio.Negocio
{
    public class Ubicacion : IFuncionesCRUD
    {
        #region propiedades
        public int Codigo { get; set; }
        public int Numero { get; set; }
        public int Fila { get; set; }
        public bool Habilitado  { get; set; }
        #endregion

        #region metodos
        public void Recuperar()
        {
            throw new NotImplementedException();
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(string param)
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
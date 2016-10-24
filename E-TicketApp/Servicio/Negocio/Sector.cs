using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class Sector : IFuncionesCRUD
    {
        #region propiedades
        public int Codigo { get; set; }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("Nombre no válido");
                }
            }
        }

        public List<Asiento> Asientos { get; set; }

        private int _precio;
        public int Precio
        {
            get { return _precio; }
            set 
            {
                if (true)
                {
                    _precio = value;
                }
                else
                {
                    throw new ArgumentException("Precio no puede ser negativo.");
                }
            }
        }

        public int CapacidadMaxima { get; set; }
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

        public List<Ubicacion> ListarAsientosDisponibles()
        {
            return (List<Ubicacion>)this.Asientos.Select(item => item.Estado = true);
        }
        #endregion
    }
}
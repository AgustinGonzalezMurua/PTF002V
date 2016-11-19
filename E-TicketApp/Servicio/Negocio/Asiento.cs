using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class Asiento : Ubicacion
    {
        #region propiedades
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

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Tipo no válido");
                }
            }
        }

        private Sector _sector;
        public Sector Sector
        {
            get { return _sector; }
            set
            {
                if (value != null)
                {
                    _sector = value;
                }
                else
                {
                    throw new ArgumentException("Sector no válido");
                }
            }
        }

        private int _precio;
        public int Precio
        {
            get { return _precio; }
            set 
            {
                if (value > 0)
                {
                    _precio = value;
                }
                else
                {
                    throw new ArgumentException("Precio no puede ser 0 o menor");
                }
            }
        }

        public bool Estado { get; set; }
        #endregion

        #region metodos
        public void Recuperar(int codigo)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Asiento asiento)
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

        public Evento MostrarEvento()
        {
            throw new NotImplementedException();
        }

        public void CambiarEstado(bool estado)
        {
            this.Estado = estado;
        }
        #endregion
    }
}

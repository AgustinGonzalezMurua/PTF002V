using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Modelo
{
    public class Asiento : Ubicacion
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

        private string _sector;
        public string Sector
        {
            get { return _sector; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
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
        public override void Recuperar(int codigo)
        {
            throw new NotImplementedException();
        }

        public override void Agregar(Asiento asiento)
        {
            throw new NotImplementedException();
        }

        public override void Modificar()
        {
            throw new NotImplementedException();
        }

        public override void Eliminar()
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

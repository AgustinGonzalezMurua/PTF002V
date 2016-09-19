using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Modelo
{
    public class Evento : IFuncionesCRUD
    {
        public string Codigo { get; set; }
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
        public DateTime Fecha { get; set; }
        public DateTime FechaCreacion { get; set; }
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
        public bool Estado { get; set; }

        public void Recuperar()
        {
            throw new NotImplementedException();
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}

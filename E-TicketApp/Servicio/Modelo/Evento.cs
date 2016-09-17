using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Modelo
{
    public class Evento : IFuncionesCRUD
    {
        public string Codigo { get; set; }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public DateTime Fecha { get; set; }
        public DateTime FechaCreacion { get; set; }
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
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

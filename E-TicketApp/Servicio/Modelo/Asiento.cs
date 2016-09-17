using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Modelo
{
    public class Asiento
    {
        public int Codigo { get; set; }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _sector;

        public string Sector
        {
            get { return _sector; }
            set { _sector = value; }
        }
        private int _precio;

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public bool Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Modelo
{
    public class Recinto : IFuncionesCRUD
    {
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
                    throw new ArgumentException("Nombre ingresado inválido.");
                }
            }
        }
        
        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _direccion = value;
                }else{
                    throw new ArgumentException("Dirección ingresada inválida");
                }
            }
        }
        
        public int CapacidadMaxima { get; set; }

        private string _fono;
        public string Fono
        {
            get { return _fono; }
            set
            {
                if (ValidadorDatos.ValidarFono(value.Trim()))
                {
                    _fono = value;
                }
                else
                {
                    throw new ArgumentException("Teléfono no válido");
                }
            }
        }
        
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

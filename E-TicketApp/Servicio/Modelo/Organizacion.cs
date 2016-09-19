using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Modelo
{
    public class Organizacion : IFuncionesCRUD
    {
        private string _rut;

        public string Rut
        {
            get { return _rut; }
            set 
            { 
                if(ValidadorDatos.ValidarRut(value)){
                    _rut = value; 
                }else{
                    throw new ArgumentException("Rut no válido");
                }
            }
        }
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
        private string _razonSocial;

        public string RazonSocial
        {
            get { return _razonSocial; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _razonSocial = value;
                }
                else
                {
                    throw new ArgumentException("Nombre no válido");
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
                }
                else
                {
                    throw new ArgumentException("Nombre no válido");
                }
            }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (ValidadorDatos.ValidarFono(value))
                {
                    _telefono = value;
                }
                else
                {
                    throw new ArgumentException("Nombre no válido");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class Usuario : IFuncionesCRUD
    {
        #region propiedades 
        public int Codigo { get; set; }
        private string _nombre;

        private string _nombreUsuario;
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set 
            { 
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _nombreUsuario = value;
                }else
                {
                    throw new ArgumentException("Usuario inválido");
                }   
            }
        }
        
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
                    throw new ArgumentException("Nombre inválido.");
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set 
            { 
                if(ValidadorDatos.ValidarCorreo(value)){
                    _email = value;
                }else{
                    throw new ArgumentException("Correo no válido.");
                }
            }
            
        }
        
        public int Tipo { get; set; }

        private string _fono;
        public string Fono
        {
            get { return _fono; }
            set 
            {
                if (ValidadorDatos.ValidarFono(value))
                {
                    _fono = value;
                }
                else
                {
                    throw new ArgumentException("Fono no válido");
                }
            }
        }
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

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public List<Compra> ListarCompras()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

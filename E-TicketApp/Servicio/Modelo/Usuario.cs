using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Modelo
{
    public class Usuario : IFuncionesCRUD   
    {
        public int Codigo { get; set; }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        public int Tipo { get; set; }
        private string _fono;

        public string Fono
        {
            get { return _fono; }
            set { _fono = value; }
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

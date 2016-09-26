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

        private string _run;
        public string RUN
        {
            get { return _run; }
            set 
            {
                if (ValidadorDatos.ValidarRun(value))
                {
                    _run = value;
                }
                else
                {
                    throw new ArgumentException("RUN inválido");
                }
            }
        }


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

        public bool ValidarUsuario(string run, string contrasena)
        {
            
            try
            {
                bool salida = false;
                if(ValidadorDatos.ValidarRun(run) && ValidadorDatos.ValidarCadena(contrasena))
                {
                    var _datos = new Dictionary<string, string>();
                    _datos.Add("RUN", run);
                    _datos.Add("Contrasena", contrasena);

                    salida = (bool)OracleSQL.ExecFunction("SFSHOW_VALIDARUSUARIO", _datos);
                }
                return salida;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

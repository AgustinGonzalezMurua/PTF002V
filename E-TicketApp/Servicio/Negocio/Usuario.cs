using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;
using System.Data;


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
            try
            {
                var _datos = new Dictionary<string, string>();
                _datos.Add("RUNUSUARIO", this.RUN);

                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_USUARIO", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    this.Nombre = rows["NOMBRE"].ToString();
                    this.Fono   = rows["TELEFONO"].ToString();
                    this.Email  = rows["EMAIL"].ToString();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void AgregarNuevoUsuario( string Clave)
        {
            try
            {
              var _diccionario = new Dictionary<string, string>();
              _diccionario.Add("P_RUN", this.RUN);
              _diccionario.Add("P_NOMBRE", this.Nombre);
              _diccionario.Add("P_TELEFONO", this.Fono);
              _diccionario.Add("P_EMAIL", this.Email);
              _diccionario.Add("P_TIPO_USUARIO", "4");
              _diccionario.Add("P_CONTRASEÑA", Clave );

              OracleSQL.ExecStoredProcedure("SPIN_USUARIO", _diccionario);
            
            }
            catch (Exception)
            {
                
                throw;
            }


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
                    _datos.Add("RUNUSUARIO", run);
                    _datos.Add("CONTRASEÑA", contrasena);
                    _datos.Add("SALIDA", "0");

                    salida = Convert.ToBoolean(Int32.Parse((string)(OracleSQL.ExecStoredProcedure("SPREC_USUARIOVALIDAR", _datos))));
                }
                return salida;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion


        public void Agregar()
        {
            throw new NotImplementedException();
        }
    }
}

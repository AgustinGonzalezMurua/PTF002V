using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;
using System.Data;

namespace Servicio.Negocio
{
    public class Organizacion : IFuncionesCRUD
    {
        #region propiedades
        private string _rut;
        public string RUT
        {
            get { return _rut; }
            set 
            { 
                if(ValidadorDatos.ValidarRun(value)){
                    _rut = value; 
                }else{
                    throw new ArgumentException("Run no válido");
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

        public string Comuna { get; set; }

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
                    throw new ArgumentException("Nombre no válido");
                }
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            {
                if (ValidadorDatos.ValidarCorreo(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Correo no válido");
                }
            }
        }
        

        public bool Estado { get; set; }

        public Usuario Organizador { get; set; }
        #endregion

        #region metodos
        public void Recuperar()
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                _datos.Add("P_RUT",this.RUT);

                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_ORGANIZACION", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    this.Nombre         = rows["NOMBRE"].ToString();
                    this.RazonSocial    = rows["RAZON_SOCIAL"].ToString();
                    this.Direccion      = rows["DIRECCION"].ToString();
                    this.Comuna         = rows["COMUNA"].ToString();
                    this.Fono           = rows["FONO"].ToString();
                    this.Email          = rows["EMAIL"].ToString();
                    this.Estado         = Convert.ToBoolean(rows["ESTADO_ORG"].ToString());
                    this.Organizador    = new Usuario(rows["ORGANIZADOR"].ToString());
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(string param)
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public List<Evento> ListarEventos()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

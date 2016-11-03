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

        public Organizacion() { }

        /// <summary>
        /// <para>Inicializa organizacion usando rut de la organización</para>
        /// </summary>
        /// <param name="rut"></param>
        public Organizacion(string rut)
        {
            try
            {
                this.RUT = rut;
                this.Recuperar();
            }
            catch (Exception)
            {
                throw;
            }
        }

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
                    this.Estado         = Convert.ToBoolean(int.Parse(rows["ESTADO_ORG"].ToString()));
                    this.Organizador    = new Usuario(rows["ORGANIZADOR"].ToString());
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Organizacion Recuperar(Usuario organizador)
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                _datos.Add("P_RUN", organizador.RUN);

                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_ORGANIZACION_RUN_USUARIO", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    this.RUT = rows["RUT"].ToString();
                    this.Nombre = rows["NOMBRE"].ToString();
                    this.RazonSocial = rows["RAZON_SOCIAL"].ToString();
                    this.Direccion = rows["DIRECCION"].ToString();
                    this.Comuna = rows["COMUNA"].ToString();
                    this.Fono = rows["FONO"].ToString();
                    this.Email = rows["EMAIL"].ToString();
                    this.Estado = Convert.ToBoolean(int.Parse(rows["ESTADO_ORG"].ToString()));
                    this.Organizador = organizador;
                }

                return this;
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
            try
            {
                var _eventos = new List<Evento>();

                var _datos = new Dictionary<string, string>();
                _datos.Add("P_RUT", this.RUT);

                var _dtEventos = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_EVENTO_POR_ORGANIZACION", _dtEventos, _datos);

                foreach (DataRow rowEvento in _dtEventos.Rows)
                {
                    var _evento             = new Evento();
                    _evento.Nombre          = rowEvento["NOMBRE"].ToString();
                    var _fecha              = new DateTime();
                    DateTime.TryParse(rowEvento["FECHA"].ToString(), out _fecha);
                    _evento.Fecha           = _fecha;
                    DateTime.TryParse(rowEvento["FECHA_CREACION"].ToString(), out _fecha);
                    _evento.FechaCreacion   = _fecha;
                    _evento.Estado          = Convert.ToBoolean(int.Parse(rowEvento["ESTADO_EVENTO"].ToString()));
                    _evento.Organizacion    = new Organizacion(rowEvento["ORGANIZACION"].ToString());
                    _evento.Recinto         = new Recinto(int.Parse(rowEvento["RECINTO"].ToString()));

                    _eventos.Add(_evento);
                }

                return _eventos;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}

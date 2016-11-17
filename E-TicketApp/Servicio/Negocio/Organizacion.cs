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

        public Comuna Comuna { get; set; }

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

                if (_dt.Rows.Count != 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.Nombre = rows["NOMBRE"].ToString();
                        this.RazonSocial = rows["RAZON_SOCIAL"].ToString();
                        this.Direccion = rows["DIRECCION"].ToString();
                        this.Comuna = new Comuna(Convert.ToInt32(rows["COMUNA"].ToString()));
                        this.Fono = rows["FONO"].ToString();
                        this.Email = rows["EMAIL"].ToString();
                        this.Estado = Convert.ToBoolean(int.Parse(rows["ESTADO_ORG"].ToString()));
                        this.Organizador = new Usuario(rows["ORGANIZADOR"].ToString());
                    }
                }
                else
                {
                    throw new KeyNotFoundException("Organización no encontrada");
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

                if (_dt.Rows.Count != 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.RUT = rows["RUT"].ToString();
                        this.Nombre = rows["NOMBRE"].ToString();
                        this.RazonSocial = rows["RAZON_SOCIAL"].ToString();
                        this.Direccion = rows["DIRECCION"].ToString();
                        this.Comuna = new Comuna(Convert.ToInt32(rows["COMUNA"].ToString()));
                        this.Fono = rows["FONO"].ToString();
                        this.Email = rows["EMAIL"].ToString();
                        this.Estado = Convert.ToBoolean(int.Parse(rows["ESTADO_ORG"].ToString()));
                        this.Organizador = organizador;
                    } 
                }
                else
                {
                    throw new KeyNotFoundException("Usuario no posee una organización asociada");
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
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_RUT", this.RUT);
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_RAZON_SOCIAL", this.RazonSocial);
                _diccionario.Add("P_DIRECCION", this.Direccion);
                _diccionario.Add("P_COMUNA", this.Comuna.ToString());
                _diccionario.Add("P_FONO", this.Fono);
                _diccionario.Add("P_EMAIL", this.Email);              
                _diccionario.Add("P_ESTADO_ORG", this.Estado.ToString());
                _diccionario.Add("P_ORGANIZADOR", this.Organizador.ToString());

                OracleSQL.ExecStoredProcedure("SPIN_ORGANIZACION", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modificar()
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_RUT", this.RUT);
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_RAZON_SOCIAL", this.RazonSocial);
                _diccionario.Add("P_DIRECCION", this.Direccion);
                _diccionario.Add("P_COMUNA", this.Comuna.ToString());
                _diccionario.Add("P_FONO", this.Fono);
                _diccionario.Add("P_EMAIL", this.Email);
                _diccionario.Add("P_ESTADO_ORG", this.Estado.ToString());
                _diccionario.Add("P_ORGANIZADOR", this.Organizador.ToString());

                OracleSQL.ExecStoredProcedure("SPMOD_ORGANIZACION", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarEstado(string rut, int estado)
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_RUT", rut);
                _diccionario.Add("ESTADO_ORG", estado.ToString());

                OracleSQL.ExecStoredProcedure("SPMOD_ESTADO_ORGANIZACION", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar()
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_RUT", this.RUT);                

                OracleSQL.ExecStoredProcedure("SPDEL_ORGANIZACION", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
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
                    _evento.Codigo          = rowEvento["CODIGO"].ToString();
                    _evento.Nombre          = rowEvento["NOMBRE"].ToString();
                    _evento.Tipo            = new TiposGeneric().RecuperarTipoEvento(Convert.ToInt32(rowEvento["TIPO_EVENTO"].ToString()));
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Organizacion> ListarOrganizaciones()
        {
            try
            {
                var _organizaciones = new List<Organizacion>();

                var _dtOrganizaciones = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_ORGANIZACIONES", _dtOrganizaciones);

                foreach (DataRow rowOrganizacion in _dtOrganizaciones.Rows)
                {
                    var _organizacion = new Organizacion();
                    _organizacion.RUT = rowOrganizacion["RUT"].ToString();
                    _organizacion.Nombre = rowOrganizacion["NOMBRE"].ToString();
                    _organizacion.RazonSocial = rowOrganizacion["RAZON_SOCIAL"].ToString();
                    _organizacion.Direccion = rowOrganizacion["DIRECCION"].ToString();
                    _organizacion.Comuna = new Comuna(int.Parse(rowOrganizacion["COMUNA"].ToString()));
                    _organizacion.Fono = rowOrganizacion["FONO"].ToString();
                    _organizacion.Email = rowOrganizacion["EMAIL"].ToString();    
                    _organizacion.Estado = Convert.ToBoolean(int.Parse(rowOrganizacion["ESTADO_ORG"].ToString()));                    
                    _organizacion.Organizador = new Usuario(rowOrganizacion["ORGANIZADOR"].ToString());

                    _organizaciones.Add(_organizacion);
                }

                return _organizaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

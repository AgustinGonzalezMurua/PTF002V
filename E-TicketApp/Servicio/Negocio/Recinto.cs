using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;
using System.Data;

namespace Servicio.Negocio
{
    public class Recinto : IFuncionesCRUD
    {
        #region propiedades
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

        public Comuna Comuna { get; set; }

        public int CapacidadMaxima { get; set; }

        public int Fono { get; set; }

        public List<Ubicacion> Ubicaciones { get; set; }
        #endregion

        #region metodos

        public Recinto() { }

        public Recinto(int codigo)
        {
            this.Codigo = codigo;
            this.Recuperar();
        }

        public Recinto(Newtonsoft.Json.Linq.JObject JObject)
        {
            this.Codigo             = Convert.ToInt32(JObject["Codigo"].ToString());
            this.Nombre             = JObject["Nombre"].ToString();
            this.Direccion          = JObject["Direccion"].ToString();
            this.Comuna             = new Negocio.Comuna(Convert.ToInt32(JObject["Comuna"]["Codigo"].ToString()));
            this.Fono               = Convert.ToInt32(JObject["Fono"].ToString());
            this.CapacidadMaxima    = Convert.ToInt32(JObject["CapacidadMaxima"].ToString());  
        }

        public void Recuperar()
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();

                _datos.Add("P_CODIGO", this.Codigo.ToString());

                OracleSQL.ExecStoredProcedure("SPREC_RECINTO", _dt, _datos);

                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.Nombre = rows["NOMBRE"].ToString();
                        this.Direccion = rows["DIRECCION"].ToString();
                        this.Comuna = new Comuna(Convert.ToInt32(rows["COMUNA"].ToString()));
                        this.Fono = int.Parse(rows["Fono"].ToString());
                        this.CapacidadMaxima = int.Parse(rows["CAPACIDAD_MAXIMA"].ToString());
                    }

                    this.Ubicaciones = this.ListarUbicacionesPorRecinto(this.Codigo);
                }
                else
                {
                    throw new KeyNotFoundException("Recinto no encontrado");
                }

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
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_DIRECCION", this.Direccion);
                _diccionario.Add("P_COMUNA", this.Comuna.Codigo.ToString());
                _diccionario.Add("P_FONO", this.Fono.ToString());
                _diccionario.Add("P_CAPACIDAD_MAX", this.CapacidadMaxima.ToString());

                String _codigo;
                OracleSQL.ExecStoredProcedure("SPIN_RECINTO", out _codigo, _diccionario);
                this.Codigo = Convert.ToInt32(_codigo);

                if (this.Ubicaciones != null)
                {
                    foreach (var ubicacion in this.Ubicaciones)
                    {
                        ubicacion.Agregar();
                    }
                }
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
                _diccionario.Add("P_CODIGO", this.Codigo.ToString());
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_DIRECCION", this.Direccion);
                _diccionario.Add("P_COMUNA", this.Comuna.Codigo.ToString());
                _diccionario.Add("P_FONO", this.Fono.ToString());
                _diccionario.Add("P_CAPACIDAD_MAX", this.CapacidadMaxima.ToString());
                OracleSQL.ExecStoredProcedure("SPMOD_RECINTO", _diccionario);
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
                _diccionario.Add("P_CODIGO", this.Codigo.ToString());
                OracleSQL.ExecStoredProcedure("SPDEL_RECINTO", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Recinto> ListarRecintos()
        {
            try
            {
                var _recintos = new List<Recinto>();
                var _dt = new DataTable();

                OracleSQL.ExecStoredProcedure("SPREC_RECINTO_TODOS", _dt);

                foreach (DataRow rows in _dt.Rows)
                {
                    var _recinto = new Recinto(Convert.ToInt32(rows["CODIGO"].ToString()));

                    _recintos.Add(_recinto);
                }

                return _recintos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ubicacion> ListarUbicacionesPorRecinto(int Codigo)
        {
            try
            {
                var _ubicaciones = new List<Ubicacion>();
                var _datos = new Dictionary<string, string>();
                _datos.Add("P_CODIGO", Codigo.ToString());
                var _dt = new DataTable();

                OracleSQL.ExecStoredProcedure("SPREC_UBICACIONES_POR_RECINTO", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    var _ubicacion = new Ubicacion();

                    _ubicacion.Codigo = Convert.ToInt32(rows["CODIGO"].ToString());
                    _ubicacion.Fila = Convert.ToChar(rows["FILA"]);
                    _ubicacion.Recinto = Convert.ToInt32(rows["RECINTO"].ToString());

                    _ubicaciones.Add(_ubicacion);
                }

                return _ubicaciones;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}

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

        public List<Ubicacion> Ubicaciones { get; set; }
        #endregion

        #region propiedades

        public Recinto() { }

        public Recinto(int codigo)
        {
            this.Codigo = codigo;
            this.Recuperar();
        }

        public void Recuperar()
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();

                _datos.Add("P_CODIGO", this.Codigo.ToString());

                OracleSQL.ExecStoredProcedure("SPREC_RECINTO", _dt, _datos);

                if (true)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.Nombre = rows["NOMBRE"].ToString();
                        this.Direccion = rows["DIRECCION"].ToString();
                        this.Comuna = new Comuna(Convert.ToInt32(rows["COMUNA"].ToString()));
                        this.Fono = rows["FONO"].ToString();
                        this.CapacidadMaxima = int.Parse(rows["CAPACIDAD_MAXIMA"].ToString());
                    }
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

        public List<Recinto> ListarRecintos()
        {
            try
            {
                var _recintos = new List<Recinto>();
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();

                OracleSQL.ExecStoredProcedure("SPREC_RECINTO_TODOS", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    var _recinto = new Recinto();

                    _recinto.Nombre = rows["CODIGO"].ToString();
                    _recinto.Nombre = rows["NOMBRE"].ToString();
                    _recinto.Direccion = rows["DIRECCION"].ToString();
                    _recinto.Comuna = new Comuna(Convert.ToInt32(rows["COMUNA"].ToString()));
                    _recinto.Fono = rows["FONO"].ToString();
                    _recinto.CapacidadMaxima = int.Parse(rows["CAPACIDAD_MAXIMA"].ToString());

                    _recintos.Add(_recinto);
                }

                return _recintos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Evento> ListarEventos()
        {
            throw new NotImplementedException();
        }

        public List<Ubicacion> ListarUbicacionesDisponibles(Evento evento)
        {
            return (List<Ubicacion>)evento.Recinto.Ubicaciones.Select(ubicacion => ubicacion.Habilitado);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio.Util;
using System.Data;

namespace Servicio.Negocio
{
    public class Sector : IFuncionesCRUD
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
                    throw new ArgumentException("Nombre no válido");
                }
            }
        }

        private int _precio;
        private int p;
        public int Precio
        {
            get { return _precio; }
            set
            {
                if (true)
                {
                    _precio = value;
                }
                else
                {
                    throw new ArgumentException("Precio no puede ser negativo.");
                }
            }
        }

        public int CapacidadMaxima { get; set; }
        public Evento Evento { get; set; }

        public List<Asiento> Asientos { get; set; }

        #endregion

        #region metodos

        public Sector() { }

        public Sector(Evento evento)
        {
            this.Evento = evento;
        }

        public Sector(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public void Recuperar()
        {
            throw new NotImplementedException();
        }

        public void Agregar()
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_PRECIO", this.Precio.ToString());
                _diccionario.Add("P_CAPACIDAD_MAX", this.CapacidadMaxima.ToString());
                _diccionario.Add("P_EVENTO", this.Evento.Codigo.ToString());

                OracleSQL.ExecStoredProcedure("SPIN_SECTOR", _diccionario);
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
                _diccionario.Add("P_PRECIO", this.Precio.ToString());
                _diccionario.Add("P_CAPACIDAD_MAX", this.CapacidadMaxima.ToString());
                _diccionario.Add("P_EVENTO", this.Evento.ToString());
                OracleSQL.ExecStoredProcedure("SPMOD_SECTOR", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        

        /*
         * Se debe modificar el procedimiento almacenado del método, el original elimina todos los sectores
         * y debe eliminar de forma individual por codigo de sector y por evento
         */
        public void Eliminar()
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_CODIGO", this.Codigo.ToString());
                OracleSQL.ExecStoredProcedure("SPDEL_SECTOR", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarSectoresPorEvento() {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_CODIGO", this.Evento.ToString());
                OracleSQL.ExecStoredProcedure("SPDEL_SECTORES_POR_EVENTO", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Sector> ListarSectoresPorEvento ()
        {
            try
            {
                var _sectores = new List<Sector>();
                var _datos = new Dictionary<string, string>();
                _datos.Add("P_CODIGO", this.Evento.Codigo.ToString());
                var _dt = new DataTable();

                OracleSQL.ExecStoredProcedure("SPREC_SECTORES_POR_EVENTO", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    var _sector = new Sector();

                    _sector.Codigo = Convert.ToInt32(rows["CODIGO"].ToString());
                    _sector.Nombre = rows["NOMBRE"].ToString();
                    _sector.Precio = Convert.ToInt32(rows["PRECIO"].ToString());
                    _sector.CapacidadMaxima = Convert.ToInt32(rows["CAPACIDAD_MAXIMA"].ToString());
                    _sector.Evento.Nombre = rows["Evento"].ToString();

                    _sectores.Add(_sector);
                }

                return _sectores;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Ubicacion> ListarAsientosDisponibles()
        {
            return (List<Ubicacion>)this.Asientos.Select(item => item.Estado = true);
        }
        #endregion
    }
}
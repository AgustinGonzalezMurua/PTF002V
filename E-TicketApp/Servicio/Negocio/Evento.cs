using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;
using System.Data;
using System.Globalization;

namespace Servicio.Negocio
{
    public class Evento : IFuncionesCRUD
    {
        #region propiedades
        public string Codigo { get; set; }

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

        public DateTime Fecha { get; set; }

        public DateTime FechaCreacion { get; set; }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Tipo no válido");
                }
            }
        }

        public Recinto Recinto { get; set; }

        public List<Sector> Sectores { get; set; }

        public Organizacion Organizacion { get; set; }

        public bool Estado { get; set; }
        #endregion

        #region metodos

        public Evento() { }

        public Evento(string codigo) 
        {
            try
            {
                this.Codigo = codigo;
                this.Recuperar();
            }
            catch (Exception)
            {
                throw;
            }
        }
    
        /// <summary>
        /// <para>Recupera el evento, si se quiere inicializar desde un nuevo Evento usar el constructor de Evento.</para>
        /// </summary>
        public void Recuperar()
        {
            try
            {
                var _datos = new Dictionary<string, string>();

                if (!ValidadorDatos.ValidarCadena(this.Codigo))
                {
                    throw new ArgumentException("Codigo no válido, se recomienda inicializar usando el constructor.");
                }

                _datos.Add("P_CODIGO", this.Codigo);

                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_EVENTO", _dt, _datos);

                foreach (DataRow rows in _dt.Rows)
                {
                    this.Codigo                 = rows["CODIGO"].ToString();
                    this.Nombre                 = rows["NOMBRE"].ToString();
                    var _fecha                  = new DateTime();
                    DateTime.TryParse(rows["FECHA"].ToString(), out _fecha);
                    this.Fecha                  = _fecha;
                    DateTime.TryParse(rows["FECHA_CREACION"].ToString(), out _fecha);
                    this.FechaCreacion          = _fecha;
                    this.Estado                 = Convert.ToBoolean(int.Parse(rows["ESTADO_EVENTO"].ToString()));
                    this.Organizacion           = new Organizacion(rows["ORGANIZACION"].ToString());
                    this.Recinto                = new Recinto(int.Parse(rows["RECINTO"].ToString()));
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

        public void ActivarEvento()
        {
            throw new NotImplementedException();
        }

        public void DesactivarEvento()
        {
            throw new NotImplementedException();
        }

        public void AgregarSector(Sector sector)
        {
            try
            {
                this.Sectores.Add(sector);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarSector(int codigoSector)
        {
            try
            {
                this.Sectores.RemoveAll(sector => sector.Codigo == codigoSector);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Sector> ListarSectoresDisponibles()
        {
            try
            {
                return (List<Sector>)this.Sectores.Select(sector => sector.Asientos.Where(asiento => asiento.Estado = false));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

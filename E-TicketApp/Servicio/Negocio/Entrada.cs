using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class Entrada : IFuncionesCRUD
    {
        #region propiedades
        public int Codigo { get; set; }
        private int _valor;

        public int Precio
        {
            get { return _valor; }
            set
            {
                if (true)
                {
                    _valor = value;
                }
                else
                {
                    throw new ArgumentException("Valor no puede ser negativo.");
                }
            }
        }

        public String NombreEvento { get; set; }
        public Asiento Asiento { get; set; }
        public Evento Evento { get; set; }
        public Recinto Recinto { get; set; }
        public Organizacion Organizacion { get; set; }
        #endregion

        #region metodos

        public Entrada() { }

        public Entrada(string codigo)
        {
            this.Codigo = Convert.ToInt32(codigo);
            this.Recuperar();
        }

        public void Recuperar()
        {
            try
            {
                var _data   = new Dictionary<string, string>();
                var _dt     = new DataTable();

                _data.Add("P_ENTRADA", this.Codigo.ToString());

                _dt = OracleSQL.ExecStoredProcedure("SPREC_ENTRADA_POR_ID", _dt,_data);

                foreach (DataRow row in _dt.Rows)
                {
                    this.Evento         = new Evento(row["EVENTO"].ToString());
                    this.Organizacion   = this.Evento.Organizacion;
                    this.Precio         = Convert.ToInt32(row["PRECIO"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public void ReservarAsiento(int codigoAsiento)
        {
            this.Asiento.CambiarEstado(true);
            this.Modificar();
        }

        public void RemoverReservaAsiento(int codigoAsiento)
        {
            this.Asiento.CambiarEstado(false);
            this.Modificar();
        }

        public List<Entrada> ListarEntradas(string cadena)
        {
            var _listaEntradas = new List<Entrada>();
            string[] _cadenaEntradas = cadena.Split(';');

            foreach (string ent in _cadenaEntradas)
            {
                if (!String.IsNullOrEmpty(ent))
                {
                    var _entrada = new Entrada(ent);
                    _listaEntradas.Add(_entrada);
                }
            }

            return _listaEntradas;
        }

        public Entrada ObtenerEvento_Precio(string codigo)
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();
                _datos.Add("P_Codigo", codigo);

                OracleSQL.ExecStoredProcedure("SPREC_EVENTOS_VALOR_ENTRADA", _dt, _datos);
               
                foreach (DataRow rows in _dt.Rows)
                {
                    this.Codigo =  Convert.ToInt32(rows["CODIGO"].ToString());
                    this.NombreEvento = rows["NOMBRE"].ToString();
                    this.Precio = Convert.ToInt32(rows["PRECIO"].ToString());
                }
                return this;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion
    }
}

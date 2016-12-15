using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class Comuna
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Comuna() { }

        public Comuna(int codigo)
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

        public void Recuperar()
        {
            var _data = new Dictionary<string, string>();
            _data.Add("P_CODIGO", this.Codigo.ToString());

            var _dt = new DataTable();
            Servicio.Util.OracleSQL.ExecStoredProcedure("SPREC_COMUNA", _dt, _data);
            foreach (DataRow row in _dt.Rows)
            {
                this.Nombre = row["NOMBRE"].ToString();
            }
        }

        public List<Comuna> ListarComunas()
        {
            try
            {
                var _comunas = new List<Comuna>();
                var _dt = new DataTable();

                OracleSQL.ExecStoredProcedure("SPREC_COMUNA_TODAS", _dt);

                foreach (DataRow rows in _dt.Rows)
                {
                    var _comuna = new Comuna(Convert.ToInt32(rows["CODIGO"].ToString()));

                    _comunas.Add(_comuna);
                }

                return _comunas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
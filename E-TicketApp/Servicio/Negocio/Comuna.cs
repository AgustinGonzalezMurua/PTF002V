using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Servicio.Negocio
{
    public class Comuna
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

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
    }
}
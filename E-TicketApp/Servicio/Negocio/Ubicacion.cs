using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio.Util;
using System.Data;
using System.Text;


namespace Servicio.Negocio
{
    public class Ubicacion : IFuncionesCRUD
    {
        #region propiedades
        public int Codigo { get; set; }        
        public char Fila { get; set; }
        public int Recinto { get; set; }
        #endregion

        #region metodos

        public Ubicacion(){}

        public Ubicacion(int codigo) {
            this.Codigo = codigo;
            this.Recuperar();
        }

        public Ubicacion(Newtonsoft.Json.Linq.JObject JObject)
        {            
            this.Codigo            = Convert.ToInt32(JObject["Codigo"].ToString());  
            this.Fila               = Convert.ToChar(JObject["Fila"].ToString());
            this.Recinto            = Convert.ToInt32(JObject["Recinto"].ToString());  
        }
    
        public void Recuperar()
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();

                _datos.Add("P_CODIGO", this.Codigo.ToString());

                OracleSQL.ExecStoredProcedure("SPREC_UBICACION", _dt, _datos);

                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.Fila = Convert.ToChar(rows["FILA"].ToString());
                        this.Recinto = int.Parse(rows["RECINTO"].ToString());
                    }
                }
                else
                {
                    throw new KeyNotFoundException("Ubicación no encontrada");
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
                _diccionario.Add("P_FILA", this.Fila.ToString());
                _diccionario.Add("P_RECINTO", this.Recinto.ToString());

                OracleSQL.ExecStoredProcedure("SPIN_UBICACION", _diccionario);
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
                _diccionario.Add("P_FILA", this.Fila.ToString());
                _diccionario.Add("P_RECINTO", this.Recinto.ToString());

                OracleSQL.ExecStoredProcedure("SPMOD_UBICACION", _diccionario);
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
                OracleSQL.ExecStoredProcedure("SPDEL_UBICACION", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
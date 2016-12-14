using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio.Util;

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

        public Ubicacion() {
            this.Codigo = 0;
            this.Fila = new char();
            this.Recinto = 0;
        }

        public Ubicacion(Newtonsoft.Json.Linq.JObject JObject)
        {            
            this.Codigo            = Convert.ToInt32(JObject["Codigo"].ToString());  
            this.Fila               = Convert.ToChar(JObject["Fecha"].ToString());
            this.Recinto            = Convert.ToInt32(JObject["Nombre"].ToString());  
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
                _diccionario.Add("P_CODIGO", this.Codigo.ToString());
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
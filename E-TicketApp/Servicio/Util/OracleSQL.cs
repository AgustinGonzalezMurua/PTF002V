﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace Servicio.Util
{
    public static class OracleSQL
    {
        private static OracleConnection ObtenerConneccion()
        {
            return new OracleConnection(ConfigurationManager.AppSettings["ConnectionStringOracle"].ToString());
        }
        
        /// <summary>
        /// <para>Ejecuta un procedimiento Almacenado</para>
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="Params"></param>
        public static DataTable ExecStoredProcedure(string StoredProcedureName, Dictionary<string,string> Params = null)
        {
            try
            {
                var _da = new OracleDataAdapter();
                var _cmd = new OracleCommand();
                _cmd.Connection = ObtenerConneccion();
                _cmd.CommandText = @StoredProcedureName;
                _cmd.CommandType = CommandType.StoredProcedure;
                foreach (var item in Params)
                {
                    _cmd.Parameters.Add(item.Key, item.Value);
                }

                _da.SelectCommand = _cmd;
                var _dt = new DataTable();
                _da.Fill(_dt);

                return _dt;
            }
            catch (Exception ex)
            {    
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FunctionName"></param>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static Object ExecFunction(string FunctionName, Dictionary<string, string> Params = null)
        {
            try
            {
                var _da = new OracleDataAdapter();
                var _cmd = new OracleCommand();
                _cmd.Connection = ObtenerConneccion();
                _cmd.CommandText = FunctionName;
                _cmd.CommandType = CommandType.StoredProcedure;

                foreach (var item in Params)
                {
                    _cmd.Parameters.Add(item.Key, item.Value);
                }

                _cmd.Connection.Open();
                _cmd.ExecuteNonQuery();
                _cmd.Connection.Close();
                _cmd.Connection.Dispose();
                _cmd.Dispose();
                return _cmd.Parameters["SALIDA"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
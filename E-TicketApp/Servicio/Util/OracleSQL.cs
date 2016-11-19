using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using Oracle.ManagedDataAccess.Types;

namespace Servicio.Util
{
    public static class OracleSQL
    {
        /// <summary>
        /// <para>Obtiene las configuraciones usando la ruta indicada en la configuración</para>
        /// </summary>
        /// <returns></returns>
        private static OracleConnection ObtenerConneccion()
        {
            try
            {
                return new OracleConnection(ConfigurationManager.AppSettings["ConnectionStringOracle"].ToString());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al leer la configuración de la aplicación \n" + ex.Message);
            }
        }
        
        /// <summary>
        /// <para>Ejecuta un procedimiento almacenado, rellenando una datatable.</para>
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="Params"></param>
        public static DataTable ExecStoredProcedure(string StoredProcedureName, DataTable Data, Dictionary<string,string> Params = null)
        {
            try
            {
                var _cmd = new OracleCommand();
                var _da = new OracleDataAdapter(_cmd);
                _cmd.Connection = ObtenerConneccion();
                _cmd.CommandText = StoredProcedureName;
                _cmd.CommandType = CommandType.StoredProcedure;

                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        _cmd.Parameters.Add(item.Key, item.Value);
                    }
                }

                var _salida = new OracleParameter();
                _salida.ParameterName = "SALIDA";
                _salida.OracleDbType = OracleDbType.RefCursor;
                _salida.Direction = ParameterDirection.Output;
                _cmd.Parameters.Add(_salida);


                _cmd.Connection.Open();
                _cmd.ExecuteNonQuery();

                _da.Fill(Data);

                CerrarConneciones(_cmd);
                return Data;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ha sucedido algo inesperado al interactuar con la base de datos \n" + ex.Message);
            }
        }

        /// <summary>
        /// <para>Ejecuta un Procedimiento almacenado, devolviendo un valor singular.</para>
        /// <para>Para el correcto uso se debe definir un parámetro de salida en <paramref name="Params"/></para>
        /// </summary>
        /// <param name="StoredProcedure"></param>
        /// <param name="Params"></param>
        /// <returns></returns>
        public static Object ExecStoredProcedure(string StoredProcedure, Dictionary<string, string> Params = null)
        {
            try
            {
                var _cmd = new OracleCommand();
                _cmd.Connection = ObtenerConneccion();
                _cmd.CommandText = StoredProcedure;
                _cmd.CommandType = CommandType.StoredProcedure;
                if (Params != null)
                {
                    foreach (var item in Params)
                    {
                        _cmd.Parameters.Add(item.Key, item.Value);
                    }
                }

                _cmd.Connection.Open();
                _cmd.ExecuteNonQuery();
                CerrarConneciones(_cmd);
                if (_cmd.Parameters.Contains("SALIDA"))
                {
                    return _cmd.Parameters["SALIDA"].Value;
                }else{
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ha sucedido algo inesperado al interactuar con la base de datos \n" + ex.Message);
            }
        }

        /// <summary>
        /// Cierra todas las conecciones del comando
        /// </summary>
        /// <param name="command"></param>
        private static void CerrarConneciones(OracleCommand command)
        {
            try
            {
                command.Connection.Close();
                command.Connection.Dispose();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ha sucedido algo inesperado al intentar cerrar la conexión \n" + ex.Message);
            }
        }
    }
}
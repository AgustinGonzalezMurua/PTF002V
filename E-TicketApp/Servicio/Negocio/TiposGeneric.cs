using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class TiposGeneric
    {
        #region Propiedades
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set
            {
                if (value > 0)
                {
                    _codigo = value;
                }
                else
                {
                    throw new ArgumentException("El código de Tipo no puede ser igual o inferior a 0");
                }
            }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set 
            {
                if (Util.ValidadorDatos.ValidarCadena(value))
                {
                    _descripcion = value;
                }
                else {
                    throw new ArgumentException("Descripción de Tipo no válida");
                }
            }
        }
        #endregion

        #region Metodos

        public TiposGeneric() { }

        public TiposGeneric(int codigo, string descripcion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }

        public TiposGeneric RecuperarTipoEvento(int Codigo)
        {
            try
            {
                this.Codigo = Codigo;

                var _dt = new DataTable();
                var _datos = new Dictionary<string, string>();
                _datos.Add("P_CODIGO", this.Codigo.ToString());
                
                OracleSQL.ExecStoredProcedure("SPREC_TIPO_EVENTO", _dt, _datos);

                if (_dt.Rows.Count != 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.Codigo = Convert.ToInt32(rows["CODIGO"].ToString());
                        this.Descripcion = rows["DESCRIPCION"].ToString();
                    }
                }
                else
                {
                    throw new KeyNotFoundException("Evento no encontrado");
                }

                return this;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TiposGeneric> RecuperarTodosTipoEvento()
        {
            try
            {
                var _tipos = new List<TiposGeneric>();
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_TIPO_EVENTO_TODOS", _dt, _datos);

                if (_dt.Rows.Count != 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        _tipos.Add(new TiposGeneric(Convert.ToInt32(rows["CODIGO"].ToString()), rows["DESCRIPCION"].ToString()));
                    }
                }

                return _tipos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TiposGeneric> RecuperarTipoUsuarios()
        {
            try
            {
                var _tipos = new List<TiposGeneric>();
                var _datos = new Dictionary<string, string>();
                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_TIPO_USUARIO_TODOS", _dt, _datos);

                if (_dt.Rows.Count != 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        _tipos.Add(new TiposGeneric(Convert.ToInt32(rows["CODIGO"].ToString()), rows["DESCRIPCION"].ToString()));
                    }
                }

                return _tipos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
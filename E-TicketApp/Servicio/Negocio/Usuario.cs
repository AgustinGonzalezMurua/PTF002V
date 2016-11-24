using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;
using System.Data;


namespace Servicio.Negocio
{
    public class Usuario : IFuncionesCRUD
    {
        #region propiedades 

        private string _run;
        public string RUN
        {
            get { return _run; }
            set 
            {
                if (ValidadorDatos.ValidarRun(value))
                {
                    _run = value;
                }
                else
                {
                    throw new ArgumentException("RUN inválido");
                }
            }
        }      

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
                    throw new ArgumentException("Nombre inválido.");
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set 
            { 
                if(ValidadorDatos.ValidarCorreo(value)){
                    _email = value;
                }else{
                    throw new ArgumentException("Correo no válido.");
                }
            }
            
        }
        
        public int Tipo { get; set; }

        public int Estado { get; set; }

        private string _fono;
        public string Fono
        {
            get { return _fono; }
            set 
            {
                if (ValidadorDatos.ValidarFono(value))
                {
                    _fono = value;
                }
                else
                {
                    throw new ArgumentException("Fono no válido");
                }
            }
        }
        #endregion

        #region metodos

        public Usuario() { }

        /// <summary>
        /// <para>Setea al usuario via rut y lo inicializa</para>
        /// </summary>
        /// <param name="run"></param>
        public Usuario(string run)
        {
            try
            {
                this.RUN = run;
                this.Recuperar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Recuperar()
        {
            try
            {
                var _datos = new Dictionary<string, string>();
                _datos.Add("P_RUN", this.RUN);

                var _dt = new DataTable();
                OracleSQL.ExecStoredProcedure("SPREC_USUARIO", _dt, _datos);

                if (_dt.Rows.Count != 0)
                {
                    foreach (DataRow rows in _dt.Rows)
                    {
                        this.Nombre = rows["NOMBRE"].ToString();
                        this.Fono   = rows["TELEFONO"].ToString();
                        this.Email  = rows["EMAIL"].ToString();
                        this.Tipo   = Convert.ToInt32(rows["TIPO_USUARIO"].ToString());
                    }
                }
                else
                {
                    throw new KeyNotFoundException("Usuario no existe");
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void AgregarNuevoUsuario( string Clave)
        {
            try
            {
              var _diccionario = new Dictionary<string, string>();
              _diccionario.Add("P_RUN", this.RUN);
              _diccionario.Add("P_NOMBRE", this.Nombre);
              _diccionario.Add("P_TELEFONO", this.Fono);
              _diccionario.Add("P_EMAIL", this.Email);
              _diccionario.Add("P_TIPO_USUARIO", "4");
              _diccionario.Add("P_CONTRASEÑA", Clave );

              OracleSQL.ExecStoredProcedure("SPIN_USUARIO", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarNuevoUsuarioPrivilegios(string Clave)
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_RUN", this.RUN);
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_TELEFONO", this.Fono);
                _diccionario.Add("P_EMAIL", this.Email);
                _diccionario.Add("P_TIPO_USUARIO", this.Tipo.ToString());
                _diccionario.Add("P_CONTRASEÑA", Clave);

                OracleSQL.ExecStoredProcedure("SPIN_USUARIO", _diccionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Agregar()
        {
            throw new InvalidProgramException("Debido a razones de seguridad se exige poseer una clave, este método se encuentra sin uso intencionalmente.");
        }

        public void Modificar()
        {
            throw new InvalidProgramException("Debido a razones de seguridad se exige poseer una clave, este método se encuentra sin uso intencionalmente.");
        }

        public void Modificar(string contrasena)
        {
            try
            {
                var _diccionario = new Dictionary<string, string>();
                _diccionario.Add("P_RUN", this.RUN);
                _diccionario.Add("P_NOMBRE", this.Nombre);
                _diccionario.Add("P_TELEFONO", this.Fono);
                _diccionario.Add("P_EMAIL", this.Email);
                _diccionario.Add("P_TIPO_USUARIO", this.Tipo.ToString());
                _diccionario.Add("P_CONTRASEÑA", contrasena.ToString());
                _diccionario.Add("P_ESTADO", (this.Estado).ToString());

                OracleSQL.ExecStoredProcedure("SPMOD_USUARIO", _diccionario);
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
                _diccionario.Add("P_RUN", this.RUN);
                _diccionario.Add("P_ESTADO", (this.Estado).ToString());

                OracleSQL.ExecStoredProcedure("SPMOD_ESTADO_USUARIO", _diccionario);

            }
            catch (Exception)
            {
                throw;
            }     
        }
 
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                var _listaUsuario = new List<Usuario>();
                var _datos = new Dictionary<string, string>();
                var _tabla = new DataTable();
                

                OracleSQL.ExecStoredProcedure("SPREC_LISTAR_USUARIO", _tabla, _datos);

                foreach (DataRow rows in _tabla.Rows)
                {
                    var _usuario = new Usuario();

                    _usuario.RUN = rows["RUN"].ToString();
                    _usuario.Nombre = rows["NOMBRE"].ToString();
                    _usuario.Fono = rows["TELEFONO"].ToString();
                    _usuario.Email = rows["EMAIL"].ToString();
                    _usuario.Tipo = Convert.ToInt32(rows["TIPO_USUARIO"].ToString());
                    _usuario.RUN = rows["RUN"].ToString();
                    _usuario.Estado = Convert.ToInt32(rows["ESTADO"].ToString());
                    _listaUsuario.Add(_usuario);

                }
                return _listaUsuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Compra> ListarCompras()
        {
            var _data = new Dictionary<string, string>();
            var _tabla = new DataTable();
            var _listaCompras = new List<Compra>();
            _data.Add("P_RUN", this.RUN);

            _tabla = OracleSQL.ExecStoredProcedure("SPREC_LISTARCOMPRAS",_tabla, _data);

            foreach (DataRow row in _tabla.Rows)
            {
                var _compra = new Compra();
                var _entrada = new Entrada();
                _entrada.Codigo = Convert.ToInt32(row["ENTRADA"].ToString());
                _compra.Codigo = Convert.ToInt32(row["CODIGO"].ToString());
                _compra.Total = Convert.ToInt32(row["TOTAL"].ToString());
                _compra.Usuario = this;
                _entrada.Recuperar();
                _compra.Entradas.Add(_entrada);

                _listaCompras.Add(_compra);
            }

            return _listaCompras;
        }

        public bool ValidarUsuario(string run, string contrasena)
        {
            try
            {
                bool salida = false;
                if(ValidadorDatos.ValidarRun(run) && ValidadorDatos.ValidarCadena(contrasena))
                {
                    var _datos = new Dictionary<string, string>();
                    _datos.Add("P_RUN", run);
                    _datos.Add("P_CONTRASEÑA", contrasena);
                    _datos.Add("SALIDA", "0");

                    salida = Convert.ToBoolean(Int32.Parse((string)(OracleSQL.ExecStoredProcedure("SPREC_USUARIO_VALIDAR", _datos))));
                }
                return salida;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

    }
}

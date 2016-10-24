using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Negocio
{
    public class Compra : IFuncionesCRUD
    {
        #region propiedades
        public int Codigo { get; set; }
        public Usuario Usuario { get; set; }
        public List<Entrada> Entradas { get; set; }
        public int Total { get; set; }
        #endregion

        #region metodos
        public void Recuperar()
        {
            throw new NotImplementedException();
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

        public void AgregarEntrada(Entrada entrada)
        {
            try
            {
                this.Entradas.Add(entrada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoverEntrada(int codigo_entrada)
        {
            try
            {
                this.Entradas.RemoveAll(entrada => entrada.Codigo.Equals(codigo_entrada));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

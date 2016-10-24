using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        
        public Asiento Asiento { get; set; }
        public Evento Evento { get; set; }
        public Recinto Recitno { get; set; }
        public Organizacion Organizacion { get; set; }
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

        public void ReservarAsiento(int codigoAsiento)
        {
            this.Asiento.CambiarEstado(true);
        }

        public void RemoverReservaAsiento(int codigoAsiento)
        {
            this.Asiento.CambiarEstado(false);
        }
        #endregion
    }
}

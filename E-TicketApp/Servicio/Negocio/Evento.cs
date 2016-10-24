using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicio.Util;

namespace Servicio.Negocio
{
    public class Evento : IFuncionesCRUD
    {
        #region propiedades
        public string Codigo { get; set; }

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
                    throw new ArgumentException("Nombre no válido");
                }
            }
        }

        public DateTime Fecha { get; set; }

        public DateTime FechaCreacion { get; set; }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (ValidadorDatos.ValidarCadena(value))
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Tipo no válido");
                }
            }
        }

        public Recinto Recinto { get; set; }

        public List<Sector> Sectores { get; set; }

        public Organizacion Organizacion { get; set; }

        public bool Estado { get; set; }
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

        public void ActivarEvento()
        {
            throw new NotImplementedException();
        }

        public void DesactivarEvento()
        {
            throw new NotImplementedException();
        }

        public void AgregarSector(Sector sector)
        {
            try
            {
                this.Sectores.Add(sector);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarSector(int codigoSector)
        {
            try
            {
                this.Sectores.RemoveAll(sector => sector.Codigo == codigoSector);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Sector> ListarSectoresDisponibles()
        {
            try
            {
                return (List<Sector>)this.Sectores.Select(sector => sector.Asientos.Where(asiento => asiento.Estado = false));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

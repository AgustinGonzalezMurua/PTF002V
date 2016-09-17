using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Modelo
{
    public class Entrada : IFuncionesCRUD
    {
        public int Codigo { get; set; }
        public Asiento Asiento { get; set; }
        public Evento Evento { get; set; }
        public Recinto Recitno { get; set; }
        public Organizacion Organizacion { get; set; }


        public void Recuperar()
        {
            throw new NotImplementedException();
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}

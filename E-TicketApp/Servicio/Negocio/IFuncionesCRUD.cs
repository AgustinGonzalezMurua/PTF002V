using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Negocio
{
    public interface IFuncionesCRUD
    {
        void Recuperar();
        void Agregar();
        void Modificar();
        void Eliminar();
    }
} 

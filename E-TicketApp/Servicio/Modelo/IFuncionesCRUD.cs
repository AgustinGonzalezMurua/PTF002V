using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Modelo
{
    interface IFuncionesCRUD
    {
        void Recuperar();
        void Agregar();
        void Modificar();
        void Eliminar();
    }
}

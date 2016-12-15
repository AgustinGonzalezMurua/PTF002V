using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vista.carrito
{
    public class Carrodecompra
    {
        #region Properties
        //listar eventos

        public List<Productosalcarro> ListaProductos { get; private set; }

        #endregion

        public static readonly Carrodecompra Instance;
        public static Carrodecompra CapturarProducto()
        {
            Carrodecompra _carrito = (Carrodecompra)HttpContext.Current.Session["Login"];
            if (_carrito == null)
            {
                HttpContext.Current.Session["Login"] = _carrito = new Carrodecompra();
            }
            return _carrito;
        }


    protected Carrodecompra()
    {
        ListaProductos = new List<Productosalcarro>();
    }

        //agrega al carrito el evento
    public void Agregar(string codigo)
    {
        Productosalcarro nuevoProducto = new Productosalcarro(codigo);
        if (ListaProductos.Contains(nuevoProducto))
        {
            foreach (Productosalcarro item in ListaProductos)
            {
                if (item.Equals(nuevoProducto))
                {
                    item.Cantidad++;
                    return;
                }
            }
        }
        else
        {
            nuevoProducto.Cantidad = 1;
            ListaProductos.Add(nuevoProducto);
        }
    }


        // elimina el evento desde el carrito
    public void EliminarProductos(string pCodigo)
    {
        Productosalcarro eliminaritems = new Productosalcarro(pCodigo);
        ListaProductos.Remove(eliminaritems);
    }
        /// reconocer la cant de productos
        /// 
        
        public void CantidadDeProductos(string pCodigo, int pCantidad)
        {
            if (pCantidad == 0)
            {
                EliminarProductos(pCodigo);
                return;
            }
            Productosalcarro updateProductos = new Productosalcarro(pCodigo);
            foreach (Productosalcarro item in ListaProductos)
            {
                if (item.Equals(updateProductos))
                {
                    item.Cantidad = pCantidad;
                    return;
                }
            }
        }

    }
}
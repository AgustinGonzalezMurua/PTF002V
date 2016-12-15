using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Collections;


namespace Vista.carrito
{
    public class Productosalcarro : IEquatable<Productosalcarro>
    {
        public string _codigo { get; set; }
       // public string _nombre;
        public int Cantidad { get; set; }
     
        public string pCodigo
        {
            get { return _codigo; }
            set
            {
                //_nombre = null;
                _codigo = value;
            }
        }

        public string Evento
        {
            get
            {
                var _resultado = JArray.Parse(new Servicio.ControladorServicioClient().RecuperarEvento_Codigo(pCodigo).ToString());
                if (_resultado == null)
                {
                    // mensaje Debe seleccionar un evento
                   
                }
                return "prueba";
            }
        }




        public Productosalcarro(string _pCodigo)
        {
            pCodigo = _pCodigo;
        }

        public bool Equals(Productosalcarro pItem)
        {
            return pItem.pCodigo == pCodigo;
        }


    }
}
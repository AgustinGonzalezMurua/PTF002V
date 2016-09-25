using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using Oracle.ManagedDataAccess.Client;
using Newtonsoft.Json;

namespace Servicio
{
    public class Normalizador
    {
        public Negocio.IFuncionesCRUD DeserializarJSON(string JSON) 
        {
            return JsonConvert.DeserializeObject<Negocio.IFuncionesCRUD>(JSON);
        }

        public string SerializarJSON(Negocio.IFuncionesCRUD obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
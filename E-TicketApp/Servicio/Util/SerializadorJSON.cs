﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Servicio.Util
{
    public static class SerializadorJSON
    {
        /// <summary>
        /// <para>Serializa una cadena singular en JSON, en este caso se debe proveer el valor y el nombre asociado a este dentro del objeto.</para>
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="nombreValor"></param>
        /// <returns></returns>
        public static string Serializar(Object valor, String nombreValor)
        {
            var _data = new Dictionary<string, string>();
            _data.Add(nombreValor, valor.ToString());
            return JsonConvert.SerializeObject(_data, Formatting.Indented);
        }

        /// <summary>
        /// <para>Serializa una DataTable en JSON</para>
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string Serializar(System.Data.DataTable valor)
        {
            return JsonConvert.SerializeObject(valor, Formatting.Indented);
        }

        /// <summary>
        /// <para>Serializa una colección en JSON</para>
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string Serializar(System.Collections.CollectionBase valor)
        {
            return JsonConvert.SerializeObject(valor, Formatting.Indented);
        }

        public static string Serializar(Negocio.IFuncionesCRUD valor)
        {
            return JsonConvert.SerializeObject(valor, Formatting.Indented);
        }
    }
}
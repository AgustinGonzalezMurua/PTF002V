using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Servicio.Util
{
    public static class ValidadorDatos{

        /// <summary>
        /// <para>Retorna si la cadena contiene caracteres válidos, exclusivamente de numeros de 0 a 9, caracteres de la 'a' a la 'z' mayúsculas y minúsculas, puntos y comas.</para>
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool ValidarCadena(string cadena){
            try
            {
                if (String.IsNullOrEmpty(cadena.Trim()))
                {
                    return false;
                }
                else
                {
                    return new Regex(@"/[^a-zA-Z,\.:0-9]/").IsMatch(cadena);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// <para>Valida correo electrónico bajo la forma RC 5322(http://www.ietf.org/rfc/rfc5322.txt)</para>
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public static bool ValidarCorreo(string correo){
            try
            {
                if (String.IsNullOrEmpty(correo.Trim()))
                {
                    return false;
                }
                else
                {
                    return new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?").IsMatch(correo);
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        /// <summary>
        /// <para>Valida número telefonico en base a el formato internacional (https://en.wikipedia.org/wiki/List_of_country_calling_codes)</para>
        /// </summary>
        /// <param name="fono"></param>
        /// <returns></returns>
        public static bool ValidarFono(string fono)
        {
            try
            {
                if (String.IsNullOrEmpty(fono.Trim()))
                {
                    return false;
                }
                else
                {
                    return new Regex(@"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$").IsMatch(fono);
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

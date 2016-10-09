using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Consumidor
{
    /// <summary>
    /// Summary description for Matematicas
    /// </summary>
    [WebService(Namespace = "http://udb.edu.sv/servicio/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Matematicas : System.Web.Services.WebService
    {

        [WebMethod]
        public string Sumar(double number1, double number2)
        {
            double suma;
            suma = number1 + number2;
            return suma.ToString();
        }

        [WebMethod]
        public string Restar(double number1, double number2)
        {
            double resta;
            resta = number1 - number2;
            return resta.ToString();
        }

        [WebMethod]
        public string Multiplicar(double number1, double number2)
        {
            double multiplicacion;
            multiplicacion = number1 * number2;
            return multiplicacion.ToString();
        }

        [WebMethod]
        public string Dividir(double number1, double number2)
        {
            if (number2 == 0)
                return "ERROR#DIV#0";
            else
            {
                double division;
                division = number1 / number2;
                return division.ToString();
            }
        }
    }
}

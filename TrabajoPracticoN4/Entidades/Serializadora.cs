using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Entidades
{
    public static class Serializadora
    {
        public static List<Socio> DeserealizarSocios(List<Socio> listadoSocios)
        {
            try
            {
                
                using (XmlTextReader reader = new XmlTextReader("ListaSocios.xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Socio>));
                    listadoSocios = (List<Socio>) ser.Deserialize(reader);
                }
            }
            
            catch (Exception)
            {
            }
            return listadoSocios;
        }
        public static List<Socio> SerealizarSocios(List<Socio> listadoSocios)
        {
            try
            {

                using (XmlTextWriter writer = new XmlTextWriter("ListaSocios.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Socio>));
                    ser.Serialize(writer, listadoSocios);
                }
            }

            catch (Exception)
            {
            }
            return listadoSocios;
        }
        public static  List<Pago> DeserealizarPagos(List<Pago> listadoPagos)
        {
            System.Text.Encoding miCodificacion = System.Text.Encoding.ASCII;
            try
            {
                using (StreamReader sr = new StreamReader("DatosPagos.json", miCodificacion))
                {
                    string json_str = sr.ReadToEnd();
                    listadoPagos = (List<Pago>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Pago>));
                }
            }
            catch (Exception)
            {
            }
            return listadoPagos;
        }
        public static void SerealizarPagos(List<Pago> listadoPagos)
        {
            System.Text.Encoding miCodificacion = System.Text.Encoding.ASCII;
            try
            {
                using (StreamWriter sr = new StreamWriter("DatosPagos.json",false, miCodificacion))
                {
                    string json_str = System.Text.Json.JsonSerializer.Serialize(listadoPagos);
                    
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

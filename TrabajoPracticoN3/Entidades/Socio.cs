using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Deportista))]
    public class Socio : ICuota
    {
        public static int numeroCorrelativo = 1;
        public int numeroSocio;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        long dni;
        public static double cuota;
        public int NumeroSocio
        {
            get
            {
                return this.numeroSocio;
            }
            set
            {
                this.numeroSocio = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        static Socio()
        {
            Socio.cuota = 800;
        }
        public Socio()
        {
        }
        public Socio(string nombre, string apellido, DateTime fechaNac, long dni) : this()
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
                throw new Exception("falta nombre o apellido");
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaDeNacimiento = fechaNac;
            this.Dni = dni;
            this.NumeroSocio = numeroCorrelativo;
            Socio.numeroCorrelativo++;
        }
        public static bool operator ==(Socio a, Socio b)
        {
            bool rta = false;
            if(a.Nombre == b.Nombre && a.Apellido == b.Apellido && a.Dni == b.Dni)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(Socio a, Socio b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if(obj is Socio && (Socio)obj == this)
                rta = true;
            return rta;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Socio N°: ");
            sb.AppendLine(this.NumeroSocio.ToString());
            sb.AppendFormat("Apellido y nombre: {0}, {1} \nDNI: {2}\nFecha de nacimiento: {3}",
                this.Apellido, this.Nombre, this.Dni, this.FechaDeNacimiento.ToShortDateString());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        double ICuota.CalcularCuota()
        {
            return Socio.cuota;
        }
    }
}

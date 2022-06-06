using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Rugbier))][XmlInclude(typeof(Futbolista))]
    public abstract class Deportista : Socio
    {
        EDeportes deporte;

        public Deportista():base()
        {
        }
        public EDeportes Deporte
        {
            get
            {
                return this.deporte;
            }
            set
            {
                this.deporte = value;
            }
        }
        public Deportista(string nombre, string apellido, DateTime fechaNac, long dni) 
            :base(nombre, apellido,fechaNac,dni)
        {
        }
        public Deportista(string nombre, string apellido, DateTime fechaNac, long dni, EDeportes deporte) 
            : this(nombre, apellido, fechaNac, dni)
        {
            this.deporte = deporte;
        }
        public abstract string Mostrar();

        public static bool operator ==(Deportista a, Deportista b)
        {
            bool rta = false;
            if((Socio)a == (Socio)b && a.deporte == b.deporte)
                rta = true;
            return rta;
        }
        public static bool operator !=(Deportista a, Deportista b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Deportista && (Deportista)obj == this)
                rta = true;
            return rta;
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Club
    {
        public List<Pago> totalPagos;
        public List<Socio> listadoDeSocios;
        //public List<Deportista> listadoDeDeportistas;
        public Club()
        {
            this.listadoDeSocios = new List<Socio>();
            this.totalPagos = new List<Pago>();
            //this.listadoDeDeportistas = new List<Deportista>();
        }
        public List<Socio> ListadoDeSocios
        {
            get
            {
                return this.listadoDeSocios;
            }
            set
            {
                this.listadoDeSocios = value;
            }
        }
        public List<Pago> TotalPagos
        {
            get
            {
                return this.totalPagos;
            }
            set
            {
                this.totalPagos = value;
            }
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listado total club: ");
            foreach (Socio item in this.listadoDeSocios)
            {
                if (item is Rugbier)
                    sb.Append(((Rugbier)item).ToString());
                else if (item is Futbolista)
                    sb.Append(((Futbolista)item).ToString());
                else
                    sb.Append(item.ToString());
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(Club club, Socio socio)
        {
            bool rta = false;
            if(socio != null && club.ListadoDeSocios != null)
            {
                foreach (Socio item in club.ListadoDeSocios)
                {
                    if(item == socio)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }
        public static bool operator !=(Club club, Socio socio)
        {
            return !(club == socio);
        }
        public static Club operator +(Club club, Socio socio)
        {
            if(socio != null && club != socio)
                club.listadoDeSocios.Add(socio);
            return club;
        }
        public Socio BuscarSocio(int numeroSocio)
        {
            Socio socioBuscado = null;
            foreach (Socio item in this.listadoDeSocios)
            {
                if (numeroSocio == item.NumeroSocio)
                {
                        socioBuscado = item;
                        break;
                }
            }
            return socioBuscado;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Futbolista : Deportista, IArancel, ICuota
    {
        static double arancel;
        ECategoriasFutbol categoria;

        public ECategoriasFutbol Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }
        static Futbolista()
        {
            Futbolista.arancel = 300;
        }
        public Futbolista():base()
        {
        }
        public Futbolista(int numeroSocio, string nombre, string apellido, DateTime fechaNac, long dni) 
            : base(numeroSocio, nombre, apellido, fechaNac, dni, EDeportes.Futbol)
        {
            this.categoria = ECategoriasFutbol.Infantiles;
        }
        public Futbolista(int numeroSocio, string nombre, string apellido, DateTime fechaNac, long dni, ECategoriasFutbol categoria)
            : this(numeroSocio, nombre, apellido, fechaNac, dni)
        {
            this.categoria = categoria;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("\nDeporte: Futbol");
            sb.AppendFormat("Categoria: {0}\n", this.categoria);

            return sb.ToString();
        }
        public static bool operator ==(Futbolista a, Futbolista b)
        {
            bool rta = false;
            if ((Socio)a == (Socio)b && a.categoria == b.categoria)
                rta = true;
            return rta;
        }
        public static bool operator !=(Futbolista a, Futbolista b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Futbolista && (Futbolista)obj == this)
                rta = true;
            return rta;
        }
        double IArancel.CalcularArancel()
        {
            double pago = 0;
            switch (this.categoria)
            {
                case ECategoriasFutbol.Infantiles:
                    pago = Futbolista.arancel * 0.7;
                    break;
                case ECategoriasFutbol.Menores:
                    pago = Futbolista.arancel * 0.85;
                    break;
                case ECategoriasFutbol.Juveniles:
                    pago = Futbolista.arancel * 0.90;
                    break;
                default:
                    pago = Futbolista.arancel;
                    break;
            }
            return pago;
        }
    }
}

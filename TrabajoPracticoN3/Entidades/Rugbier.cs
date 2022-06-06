using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rugbier : Deportista, IArancel, ICuota
    {
        static double arancel;
        ECategoriasRugby categoria;

        public ECategoriasRugby Categoria
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
        static Rugbier()
        {
            Rugbier.arancel = 450;
        }
        public Rugbier():base()
        {
        }
        public Rugbier(string nombre, string apellido, DateTime fechaNac, long dni) : base(nombre, apellido, fechaNac, dni, EDeportes.Rugby)
        {
            this.categoria = ECategoriasRugby.Sub14;
        }
        public Rugbier(string nombre, string apellido, DateTime fechaNac, long dni, ECategoriasRugby categoria) : this(nombre, apellido, fechaNac, dni)
        {
            this.categoria = categoria;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("\nDeporte: Rugby");
            sb.AppendFormat("Categoria: {0}\n", this.categoria);

            return sb.ToString();
        }
        public static bool operator ==(Rugbier a, Rugbier b)
        {
            bool rta = false;
            if ((Deportista)a == (Deportista)b && a.categoria == b.categoria)
                rta = true;
            return rta;
        }
        public static bool operator !=(Rugbier a, Rugbier b)
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
            if (obj is Rugbier && (Rugbier)obj == this)
                rta = true;
            return rta;
        }
        double IArancel.CalcularArancel()
        {
            double pago = 0;
            switch(this.categoria)
            {
                case ECategoriasRugby.Sub14:
                    pago = Rugbier.arancel * 0.7;
                    break;
                case ECategoriasRugby.Sub16:
                    pago = Rugbier.arancel * 0.85;
                    break;
                case ECategoriasRugby.Sub18:
                    pago = Rugbier.arancel * 0.90;
                    break;
                default:
                    pago = Rugbier.arancel;
                    break;
            }
            return pago;
        }
    }
}

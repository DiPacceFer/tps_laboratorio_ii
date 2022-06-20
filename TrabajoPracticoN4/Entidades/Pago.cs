using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        int idPago;
        double importe;
        Socio socio;
        DateTime fechaPago;

        public double Importe
        {
            get
            {
                return this.importe;
            }
            set
            {
                this.importe = value;
            }
        }
        public DateTime FechaPago
        {
            get
            {
                return this.fechaPago;
            }
            set
            {
                this.fechaPago = value;
            }
        }
        public Socio Socio
        {
            get
            {
                return this.socio;
            }
            set
            {
                this.socio = value;
            }
        }

        public int IdPago { get => idPago; set => idPago = value; }

        public Pago()
        {
        }
        public Pago(double importe, DateTime fechaPago, Socio socio) :this()
        {
            this.importe = importe;
            this.socio = socio;
            this.fechaPago = fechaPago;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Fecha de pago: ");
            sb.AppendLine(this.FechaPago.ToShortDateString());
            sb.Append(" Importe: ");
            sb.AppendLine(this.Importe.ToString());
            sb.AppendLine(this.Socio.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}

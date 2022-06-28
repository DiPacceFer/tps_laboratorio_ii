using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace FomulariosTP3
{
    public partial class FrmCobroCuota : Form
    {
        public Club auxClub;
        public List<Pago> listadoPagos;
        public Socio socioBuscado;
        protected Pago pago;
        
        public FrmCobroCuota()
        {
            InitializeComponent();
            this.auxClub = new Club();
            this.auxClub.TotalPagos = GestorSQL.LeerDatosPago();
            this.auxClub.ListadoDeSocios = GestorSQL.LeerDatosSocio();
        }
        
        public virtual void MostrarSocioBuscado(Socio socioBuscado)
        {
            this.listBox_SocioBuscado.Items.Add(socioBuscado);
        }
        public virtual bool Cobrar()
        {
            bool rta = false;
            try
            {
                double importe = Cobro.CobrarCuota(((Socio)this.listBox_SocioBuscado.SelectedItem));
                Pago pago = new Pago(importe, DateTime.Now, socioBuscado);
                GestorSQL.AltaPago(pago);
                rta = true;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Debe seleccionar socio");
            }
            return rta;
        }

        public virtual void button_CobrarCuota_Click(object sender, EventArgs e)
        {
            if(this.Cobrar())
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Cuota cobrada correctamente");
                this.Close();
            }
        }
        public virtual void button_BuscarSocio_Click(object sender, EventArgs e)
        {
            if (this.textBox_NumeroSocio.Text != null && this.textBox_NumeroSocio.Text.Length != 0)
            {
                socioBuscado = auxClub.BuscarSocio(int.Parse(this.textBox_NumeroSocio.Text));
                if (socioBuscado is not null)
                    this.MostrarSocioBuscado(socioBuscado);
                else
                    MessageBox.Show("No se encontro el socio");
            }
            else
                MessageBox.Show("Ingrese un numero de socio valido");
        }
    }
}

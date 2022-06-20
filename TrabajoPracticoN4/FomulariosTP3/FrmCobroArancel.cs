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
using System.IO;

namespace FomulariosTP3
{
    public partial class FrmCobroArancel : FrmCobroCuota
    {
        public FrmCobroArancel()
        {
            InitializeComponent();
            this.auxClub = new Club();
            this.auxClub.TotalPagos = GestorSQL.LeerDatosPago();
            this.auxClub.ListadoDeSocios = GestorSQL.LeerDatosSocio();
        }
        public override void button_CobrarCuota_Click(object sender, EventArgs e)
        {
            base.Cobrar();
            this.Cobrar();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public override bool Cobrar()
        {
            bool rta = false;
            double importe = 0;
            Pago pago = null;
            Deportista auxDeportista = (Deportista)this.listBox_SocioBuscado.SelectedItem;
            if(auxDeportista is not null)
            {
                if (auxDeportista is Futbolista)
                {
                    importe = Cobro.CobrarArancel(((Futbolista)this.listBox_SocioBuscado.SelectedItem));
                    pago = new Pago(importe, DateTime.Now, auxDeportista);
                }
                else if(auxDeportista is Rugbier)
                {
                    importe = Cobro.CobrarArancel(((Rugbier)this.listBox_SocioBuscado.SelectedItem));
                    pago = new Pago(importe, DateTime.Now, auxDeportista);
                }
                rta = true;
            }
            else
            {
                MessageBox.Show("No se selecciono ningun Deportista para cobrar arancel");
            }
            GestorSQL.AltaPago(pago);
            return rta;
        }
        public override void button_BuscarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox_NumeroSocio.Text != null && this.textBox_NumeroSocio.Text.Length != 0 )
                {
                    socioBuscado = auxClub.BuscarSocio(int.Parse(this.textBox_NumeroSocio.Text));
                    if (socioBuscado is Deportista)
                        this.MostrarSocioBuscado(socioBuscado);
                    else
                    {
                        MessageBox.Show("No puede cobrar arancel porque no es Deportista");
                        this.Close();
                    }
                }
                else
                {
                    throw new ArgumentNullException("Numero de socio nulo o vacio");
                }
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MostrarDeportistaBuscado(Socio deportistaBuscado)
        {
            this.listBox_SocioBuscado.Items.Add(deportistaBuscado);
        }
    }
}

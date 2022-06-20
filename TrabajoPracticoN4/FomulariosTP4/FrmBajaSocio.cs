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
using System.Xml.Serialization;
using System.Xml;

namespace FomulariosTP3
{
    public delegate void CambiarColorBotonHandler(Button boton);
    public partial class FrmBajaSocio : Form
    {
        public Club auxClub;
        public Socio socioBuscado;
        public event CambiarColorBotonHandler OnCambiarColorBoton;
        public FrmBajaSocio()
        {
            InitializeComponent();
            this.auxClub = new Club();
        }
        private void button_BuscarSocio_Click(object sender, EventArgs e)
        {
            if (this.txtBox_NumeroSocio.Text != null && this.txtBox_NumeroSocio.Text.Length != 0)
            {
                auxClub.listadoDeSocios = GestorSQL.LeerDatosSocio();
                socioBuscado = auxClub.BuscarSocio(int.Parse(this.txtBox_NumeroSocio.Text));
                if (!(socioBuscado is null))
                    this.MostrarSocioBuscado(socioBuscado);
                else
                    MessageBox.Show("No se encontro socio");
            }
            else
                MessageBox.Show("Ingrese un numero de socio valido");
        }
        public virtual void MostrarSocioBuscado(Socio socioBuscado)
        {
            this.listBox_DatosSocio.Items.Add(socioBuscado);
            this.OnCambiarColorBoton += CambiarColorBoton;
            this.OnCambiarColorBoton.Invoke(button_Baja);
        }
        private void button_Baja_Click(object sender, EventArgs e)
        {
            if (this.listBox_DatosSocio.SelectedItem is null)
                MessageBox.Show("Debe seleccionar al socio del listado");
            else
                GestorSQL.EliminarSocio((Socio)this.listBox_DatosSocio.SelectedItem);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Baja de socio exitosa");
            this.Close();
        }
        private void CambiarColorBoton(Button botonBaja)
        {
            this.button_Baja.BackColor = Color.Red;
        }
    }
}

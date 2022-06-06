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
    public partial class FrmBajaSocio : Form
    {
        public Club auxClub;
        public Socio socioBuscado;
        public FrmBajaSocio()
        {
            InitializeComponent();
            this.auxClub = new Club();
            this.auxClub.ListadoDeSocios = this.ObtenerDatosSocioArchivo(this.auxClub.ListadoDeSocios);
        }


        public List<Socio> ObtenerDatosSocioArchivo(List<Socio> listadoSocios)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader("ListaSocios.xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Socio>));
                    listadoSocios = (List<Socio>)ser.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listadoSocios;
        }
        public virtual void CargarDatosEnArchivo(Club club)
        {
            System.Text.Encoding miCodificacion = System.Text.Encoding.UTF8;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("ListaSocios.xml",
                     miCodificacion))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Socio>));
                    ser.Serialize(writer, club.listadoDeSocios);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button_BuscarSocio_Click(object sender, EventArgs e)
        {
            if (this.txtBox_NumeroSocio.Text != null && this.txtBox_NumeroSocio.Text.Length != 0)
            {
                socioBuscado = auxClub.BuscarSocio(int.Parse(this.txtBox_NumeroSocio.Text));
                this.MostrarSocioBuscado(socioBuscado);
            }
            else
                MessageBox.Show("Ingrese un numero de socio valido");
        }
        public virtual void MostrarSocioBuscado(Socio socioBuscado)
        {
            this.listBox_DatosSocio.Items.Add(socioBuscado);
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            auxClub.ListadoDeSocios.Remove(socioBuscado);
            this.CargarDatosEnArchivo(auxClub);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Baja de socio exitosa");
            this.Close();
        }
    }
}

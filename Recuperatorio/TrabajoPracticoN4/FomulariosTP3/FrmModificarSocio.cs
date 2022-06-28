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
    public partial class FrmModificarSocio : Form
    {
        public Club auxClub;
        public Socio socioBuscado;
        public FrmModificarSocio()
        {
            InitializeComponent();
            this.auxClub = new Club();
            this.auxClub.ListadoDeSocios = GestorSQL.LeerDatosSocio();
        }
        public virtual void MostrarSocioBuscado(Socio socioBuscado)
        {
            try
            {
                this.listBox_SocioBuscado.Items.Add(socioBuscado);
                this.textBox_Nombre.Text = socioBuscado.Nombre;
                this.textBox_Apellido.Text = socioBuscado.Apellido;
                this.textBox_Dni.Text = socioBuscado.Dni.ToString();
                this.dateTimePicker_FechaNac.Text = socioBuscado.FechaDeNacimiento.ToString();

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No pueden quedar datos vacios");
            }
        }
        private void button_BuscarSocio_Click(object sender, EventArgs e)
        {
            if (this.textBox_NumeroSocio.Text != null && this.textBox_NumeroSocio.Text.Length != 0)
            {
                socioBuscado = auxClub.BuscarSocio(int.Parse(this.textBox_NumeroSocio.Text));
                if (!(socioBuscado is null)) 
                    this.MostrarSocioBuscado(socioBuscado);
                else
                    MessageBox.Show("No se encontro socio");
            }
            else
                MessageBox.Show("Ingrese un numero de socio valido");
        }

        private void button_Modificar_Click(object sender, EventArgs e)
        { 
            socioBuscado.Nombre = this.textBox_Nombre.Text;
            socioBuscado.Apellido = this.textBox_Apellido.Text;
            socioBuscado.Dni = int.Parse(this.textBox_Dni.Text);
            socioBuscado.FechaDeNacimiento = new DateTime(dateTimePicker_FechaNac.Value.Year, dateTimePicker_FechaNac.Value.Month,
                dateTimePicker_FechaNac.Value.Day);
            GestorSQL.ActualizarDatosSocio(socioBuscado);
            MessageBox.Show("Datos de socio modificados correctamente");
            this.Close();
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
    }
}

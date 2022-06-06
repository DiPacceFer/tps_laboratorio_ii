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
using System.IO;

namespace FomulariosTP3
{
    public partial class FrmAltaSocio : Form
    {
        public Club club;
        public FrmAltaSocio()
        {
            InitializeComponent();
            this.club = new Club();
            this.club = this.ObtenerDatosDeArchivo(this.club);
            if (club.ListadoDeSocios.Count != 0)
                Socio.numeroCorrelativo = club.ListadoDeSocios.Count + 1;
            this.lb_NumeroSocio.Text = Socio.numeroCorrelativo.ToString();
        }

        public virtual void button_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaNac = new DateTime(dateTimePicker_FechaNac.Value.Year, dateTimePicker_FechaNac.Value.Month, 
                    dateTimePicker_FechaNac.Value.Day);
                long dni = (long)Convert.ToDouble(this.textBox_DNI.Text);
                Socio nuevoSocio = new Socio(this.txbx_Nombre.Text.ToString(), this.textBox_Apellido.Text.ToString(), fechaNac, dni);
                this.club += nuevoSocio;
                this.CargarDatosEnArchivo(club);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error en ingreso de datos. No corresponde el formato de dato ingresado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            catch (Exception)
            {
            }
        }
        public Club ObtenerDatosDeArchivo(Club club)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader("ListaSocios.xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Socio>));
                    club.ListadoDeSocios = (List<Socio>)ser.Deserialize(reader);
                }
            }
            catch (Exception)
            {
            }
            return club;
        }
    }
}

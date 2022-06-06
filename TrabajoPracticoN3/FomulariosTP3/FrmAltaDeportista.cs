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
    public partial class FrmAltaDeportista : FrmAltaSocio
    {
        public FrmAltaDeportista():base()
        {
            InitializeComponent();
            this.comboBox_Deporte.DataSource = Enum.GetValues(typeof(EDeportes));
            this.comboBox_Deporte.DropDownStyle = ComboBoxStyle.DropDownList;
            if ((EDeportes)this.comboBox_Deporte.SelectedItem == EDeportes.Rugby)
                this.comboBox_Categoria.DataSource = Enum.GetValues(typeof(ECategoriasRugby));
            else if ((EDeportes)this.comboBox_Deporte.SelectedItem == EDeportes.Futbol)
                this.comboBox_Categoria.DataSource = Enum.GetValues(typeof(ECategoriasFutbol));
            this.comboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public override void button_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaNac = new DateTime(dateTimePicker_FechaNac.Value.Year, dateTimePicker_FechaNac.Value.Month,
                dateTimePicker_FechaNac.Value.Day);
                long dni = (long)Convert.ToDouble(this.textBox_DNI.Text);
                if((EDeportes)this.comboBox_Deporte.SelectedItem == EDeportes.Rugby)
                {
                    Rugbier nuevoRugbier = new Rugbier(this.txbx_Nombre.Text.ToString(), this.textBox_Apellido.Text.ToString(), fechaNac,
                        dni, (ECategoriasRugby)this.comboBox_Categoria.SelectedItem);
                    this.club = this.ObtenerDatosDeArchivo(this.club);
                    this.club += nuevoRugbier;
                    this.CargarDatosEnArchivo(club);
                }
                else if((EDeportes)this.comboBox_Deporte.SelectedItem == EDeportes.Futbol)
                {
                    Futbolista nuevoFutbolista = new Futbolista(this.txbx_Nombre.Text.ToString(), this.textBox_Apellido.Text.ToString(), fechaNac,
                        dni, (ECategoriasFutbol)this.comboBox_Categoria.SelectedItem);
                    this.club = this.ObtenerDatosDeArchivo(this.club);
                    this.club += nuevoFutbolista;
                    this.CargarDatosEnArchivo(club);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Verificar datos ingresados");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public override void CargarDatosEnArchivo(Club club)
        {
            System.Text.Encoding miCodificacion = System.Text.Encoding.UTF8;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("ListaSocios.xml", miCodificacion))
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

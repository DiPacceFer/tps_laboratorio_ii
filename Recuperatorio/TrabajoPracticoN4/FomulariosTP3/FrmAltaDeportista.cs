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
                    Rugbier nuevoRugbier = new Rugbier(this.numeroSocio, this.txbx_Nombre.Text.ToString(), this.textBox_Apellido.Text.ToString(), fechaNac,
                        dni, (ECategoriasRugby)this.comboBox_Categoria.SelectedItem);
                    this.VerificarIngresoDatos();
                    GestorSQL.AltaRugbier(nuevoRugbier);
                }
                else if((EDeportes)this.comboBox_Deporte.SelectedItem == EDeportes.Futbol)
                {
                    Futbolista nuevoFutbolista = new Futbolista(this.numeroSocio, this.txbx_Nombre.Text.ToString(), this.textBox_Apellido.Text.ToString(), fechaNac,
                        dni, (ECategoriasFutbol)this.comboBox_Categoria.SelectedItem);
                    this.VerificarIngresoDatos();
                    GestorSQL.AltaFutbolista(nuevoFutbolista);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

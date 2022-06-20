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
        protected int numeroSocio;
        public FrmAltaSocio()
        {
            InitializeComponent();
            this.club = new Club();
            this.club.listadoDeSocios = GestorSQL.LeerDatosSocio();
            if (club.ListadoDeSocios.Count != 0)
                numeroSocio = club.ListadoDeSocios.Count + 1;
            this.lb_NumeroSocio.Text = numeroSocio.ToString();
        }

        public virtual void button_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaNac = new DateTime(dateTimePicker_FechaNac.Value.Year, dateTimePicker_FechaNac.Value.Month, 
                    dateTimePicker_FechaNac.Value.Day);
                long dni = (long)Convert.ToDouble(this.textBox_DNI.Text);
                Socio nuevoSocio = new Socio(numeroSocio, this.txbx_Nombre.Text.ToString(), this.textBox_Apellido.Text.ToString(), fechaNac, dni);
                this.VerificarIngresoDatos();
                GestorSQL.AltaSocio(nuevoSocio);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected bool VerificarIngresoDatos()
        {
            bool rta = false;
            int n = 0;
            try
            {
                DateTime fechaNac = new DateTime(dateTimePicker_FechaNac.Value.Year, dateTimePicker_FechaNac.Value.Month,
                    dateTimePicker_FechaNac.Value.Day);
                if (string.IsNullOrEmpty((this.txbx_Nombre).ToString()) || string.IsNullOrEmpty((this.textBox_Apellido).ToString()) || string.IsNullOrEmpty(this.textBox_DNI.Text))
                    throw new IngresoDeDatosException("No se Ingreso datos");
                long dni = (long)Convert.ToDouble(this.textBox_DNI.Text);
                if (int.TryParse((this.txbx_Nombre).ToString(), out n) || int.TryParse((this.textBox_Apellido).ToString(), out n))
                    throw new IngresoDeDatosException("No se pueden ingresar numeros en nombre o apellido");
                rta = true;
            }
            catch (IngresoDeDatosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, ingresar solo numeros en el DNI");
            }
            return rta;
        }

    }

}

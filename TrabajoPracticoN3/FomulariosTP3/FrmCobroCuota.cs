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
using System.Xml.Serialization;
using System.Xml;


namespace FomulariosTP3
{
    public partial class FrmCobroCuota : Form
    {
        public Club auxClub;
        public List<Pago> listadoPagos;
        public Socio socioBuscado;
        
        public FrmCobroCuota()
        {
            InitializeComponent();
            this.auxClub = new Club();
            this.auxClub.TotalPagos = this.ObtenerDatosDePagoArchivo(this.auxClub.TotalPagos);
            this.auxClub.ListadoDeSocios = this.ObtenerDatosSocioArchivo(this.auxClub.ListadoDeSocios);
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
                auxClub.TotalPagos.Add(pago);
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
                this.CargarDatosEnArchivo(auxClub);
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
                this.MostrarSocioBuscado(socioBuscado);
            }
            else
                MessageBox.Show("Ingrese un numero de socio valido");
        }
        public List<Pago> ObtenerDatosDePagoArchivo(List<Pago> listadoPagos)
        {
            System.Text.Encoding miCodificacion = System.Text.Encoding.ASCII;
            try
            {
                using (StreamReader sr = new StreamReader("DatosPagos.json", miCodificacion))
                {
                    string json_str = sr.ReadToEnd();
                    listadoPagos = (List<Pago>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Pago>));
                }
            }
            catch (Exception)
            {
            }
            return listadoPagos;
        }
        public virtual void CargarDatosEnArchivo(Club club)
        {
            System.Text.Encoding miCodificacion = System.Text.Encoding.ASCII;
            string club_json = System.Text.Json.JsonSerializer.Serialize(this.auxClub.TotalPagos);
            try
            {
                using (StreamWriter sw = new StreamWriter("DatosPagos.json", false, miCodificacion))
                {
                    sw.WriteLine(club_json);
                }
            }
            catch (Exception)
            {
            }
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
            catch (Exception)
            {
            }
            return listadoSocios;
        }
    }
}

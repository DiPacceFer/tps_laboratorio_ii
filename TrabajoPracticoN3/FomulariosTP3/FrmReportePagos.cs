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
    public partial class FrmReportePagos : FrmReporteSocios
    {
        Club auxClub;
        public FrmReportePagos()
        {
            InitializeComponent();
            auxClub = new Club();
        }
        public void ReportePagos()
        {
            auxClub = this.ObtenerDatosDeArchivo(auxClub);
            foreach (Pago item in auxClub.totalPagos)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }
        public override Club ObtenerDatosDeArchivo(Club club)
        {
            List<Pago> auxListado = null;
            System.Text.Encoding miCodificacion = System.Text.Encoding.ASCII;
            try
            {
                using (StreamReader sr = new StreamReader("DatosPagos.json", miCodificacion))
                {
                    string json_str = sr.ReadToEnd();
                    auxListado = (List<Pago>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Pago>));
                    auxClub.totalPagos = auxListado;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return auxClub;
        }
    }
}

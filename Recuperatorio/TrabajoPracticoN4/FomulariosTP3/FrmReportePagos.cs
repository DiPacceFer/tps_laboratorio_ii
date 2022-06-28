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
            auxClub.TotalPagos = GestorSQL.LeerDatosPago();
            if (!(auxClub.TotalPagos is null))
            {
                foreach (Pago item in auxClub.TotalPagos)
                {
                    this.listBox1.Items.Add(item.ToString());
                }
            }
            else
                MessageBox.Show("No se registraron pagos aun");
        }
    }
}

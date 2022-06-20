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

namespace FomulariosTP3
{
    public partial class FrmReporteSocios : Form
    {
        public FrmReporteSocios()
        {
            InitializeComponent();
        }
        
        public void ReporteSocios()
        {
            Club auxClub = new Club();
            auxClub.ListadoDeSocios = GestorSQL.LeerDatosSocio();
            foreach (Socio item in auxClub.listadoDeSocios)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }
    }
}

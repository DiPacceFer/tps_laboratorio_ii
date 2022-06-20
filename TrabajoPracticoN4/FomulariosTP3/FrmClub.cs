using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace FomulariosTP3
{
    public partial class FrmClub : Form
    {
        public static Club club;
        
        public FrmClub()
        {
            InitializeComponent();
        }
        static FrmClub()
        {
            FrmClub.club = new Club();
            FrmClub.IniciarDatos(FrmClub.club); 
        }
        
        private void socioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaSocio altaSocio = new FrmAltaSocio();
            altaSocio.Show();
        }
        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaDeportista altaDeportista = new FrmAltaDeportista();
            altaDeportista.Show();
        }
        private void totalSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteSocios reporteSocios = new FrmReporteSocios();
            reporteSocios.ReporteSocios();
            reporteSocios.Show();
        }

        private void cuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCobroCuota cobroCuota = new FrmCobroCuota();
            try
            {
                cobroCuota.Show();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Debe haber al menos un socio para poder cobrar cuota");
            }
        }

        private void cobrarDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCobroArancel cobroArancel = new FrmCobroArancel();
            cobroArancel.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaSocio bajaSocio = new FrmBajaSocio();
            bajaSocio.Show();
        }

        private void deporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePagos reportePagos = new FrmReportePagos();
            reportePagos.ReportePagos();
            reportePagos.Show();
        }

        private void altaDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarSocio modificarDatos = new FrmModificarSocio();
            modificarDatos.Show();
        }
        private static void IniciarDatos(Club club)
        {
            try
            {
                Task tarea = new Task(GestorSQL.CrearTablaSocios);
                tarea.Start();
                //GestorSQL.CrearTablaSocios();
                if (!File.Exists("ListaSocios.xml"))
                    throw new FileNotFoundException();
                else
                {
                    tarea.Wait();
                    FrmClub.club.ListadoDeSocios = Serializadora.DeserealizarSocios(FrmClub.club.ListadoDeSocios);
                    GestorSQL.CargarTablaSocios(FrmClub.club.ListadoDeSocios);
                }
            }
            catch (FileNotFoundException)
            {
            }
            try
            {
                Task tarea2 = new Task(GestorSQL.CrearTablaPagos);
                tarea2.Start();
                //GestorSQL.CrearTablaPagos();
                if (!File.Exists("DatosPagos.json"))
                    throw new FileNotFoundException();
                else
                {
                    tarea2.Wait();
                    FrmClub.club.TotalPagos = Serializadora.DeserealizarPagos(FrmClub.club.TotalPagos);
                    GestorSQL.CargarTablaPagos(FrmClub.club.TotalPagos);
                }
            }
            catch (FileNotFoundException)
            {
            }

        }
        private void FormClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.Yes)
            {
                Serializadora.SerealizarSocios(GestorSQL.LeerDatosSocio());
                Serializadora.SerealizarPagos(GestorSQL.LeerDatosPago());
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}


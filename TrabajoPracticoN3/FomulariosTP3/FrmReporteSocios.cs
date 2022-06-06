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
    public partial class FrmReporteSocios : Form
    {
        public FrmReporteSocios()
        {
            InitializeComponent();
        }
        
        public void ReporteSocios()
        {
            Club auxClub = new Club();
            auxClub = this.ObtenerDatosDeArchivo(auxClub);
            foreach (Socio item in auxClub.listadoDeSocios)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }
        public virtual Club ObtenerDatosDeArchivo(Club club)
        {
            try
            {
                if (!File.Exists("ListaSocios.xml"))
                    throw new FileNotFoundException();
                using (XmlTextReader reader = new XmlTextReader("ListaSocios.xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Socio>));
                    club.ListadoDeSocios = (List<Socio>)ser.Deserialize(reader);
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("No se ha cargado ningun socio aun");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return club;
        }

    }
}

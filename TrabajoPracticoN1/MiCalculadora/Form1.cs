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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando(this.textNumero1.Text);
            Operando numero2 = new Operando(this.textNumero2.Text);
            this.labelResultado.Text = (Operar(this.textNumero1.Text, this.textNumero2.Text, this.Operador.Text)).ToString();
            StringBuilder operacion = new StringBuilder();
            operacion.AppendFormat("{0} {1} {2} = {3}", this.textNumero1.Text, this.Operador.Text, this.textNumero2.Text, this.labelResultado.Text);
            this.listBox1.Items.Add(operacion);
        }
        static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            return Calculadora.Operar(num1, num2, char.Parse(operador));
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void Limpiar()
        {
            this.textNumero1.Text = "";
            this.textNumero2.Text = "";
            this.Operador.Text = "";
            this.labelResultado.Text = "0";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double resultadoOperacion = Convert.ToDouble(this.labelResultado.Text);
            this.labelResultado.Text = Operando.DecimalBinario(this.labelResultado.Text);
            StringBuilder operacion = new StringBuilder();
            operacion.AppendFormat("{0} = {1}", resultadoOperacion, this.labelResultado.Text);
            this.listBox1.Items.Add(operacion);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string Binario = this.labelResultado.Text;
            if(Operando.EsBinario(this.labelResultado.Text))
            {
                this.labelResultado.Text = Operando.BinarioDecimal(this.labelResultado.Text);
                StringBuilder operacion = new StringBuilder();
                operacion.AppendFormat("{0} = {1}", Binario, this.labelResultado.Text);
                this.listBox1.Items.Add(operacion);
            }
        }
    }
}

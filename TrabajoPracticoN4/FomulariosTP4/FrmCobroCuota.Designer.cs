
namespace FomulariosTP3
{
    partial class FrmCobroCuota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_SocioBuscado = new System.Windows.Forms.ListBox();
            this.lb_BusquedaSocio = new System.Windows.Forms.Label();
            this.textBox_NumeroSocio = new System.Windows.Forms.TextBox();
            this.button_CobrarCuota = new System.Windows.Forms.Button();
            this.button_BuscarSocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_SocioBuscado
            // 
            this.listBox_SocioBuscado.FormattingEnabled = true;
            this.listBox_SocioBuscado.ItemHeight = 25;
            this.listBox_SocioBuscado.Location = new System.Drawing.Point(12, 40);
            this.listBox_SocioBuscado.Name = "listBox_SocioBuscado";
            this.listBox_SocioBuscado.Size = new System.Drawing.Size(440, 404);
            this.listBox_SocioBuscado.TabIndex = 0;
            // 
            // lb_BusquedaSocio
            // 
            this.lb_BusquedaSocio.AutoSize = true;
            this.lb_BusquedaSocio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_BusquedaSocio.Location = new System.Drawing.Point(491, 40);
            this.lb_BusquedaSocio.Name = "lb_BusquedaSocio";
            this.lb_BusquedaSocio.Size = new System.Drawing.Size(151, 25);
            this.lb_BusquedaSocio.TabIndex = 1;
            this.lb_BusquedaSocio.Text = "Numero de Socio";
            // 
            // textBox_NumeroSocio
            // 
            this.textBox_NumeroSocio.Location = new System.Drawing.Point(492, 68);
            this.textBox_NumeroSocio.Name = "textBox_NumeroSocio";
            this.textBox_NumeroSocio.Size = new System.Drawing.Size(150, 31);
            this.textBox_NumeroSocio.TabIndex = 2;
            this.textBox_NumeroSocio.Text = "1";
            this.textBox_NumeroSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_CobrarCuota
            // 
            this.button_CobrarCuota.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CobrarCuota.Location = new System.Drawing.Point(492, 319);
            this.button_CobrarCuota.Name = "button_CobrarCuota";
            this.button_CobrarCuota.Size = new System.Drawing.Size(260, 97);
            this.button_CobrarCuota.TabIndex = 3;
            this.button_CobrarCuota.Text = "Cobrar";
            this.button_CobrarCuota.UseVisualStyleBackColor = true;
            this.button_CobrarCuota.Click += new System.EventHandler(this.button_CobrarCuota_Click);
            // 
            // button_BuscarSocio
            // 
            this.button_BuscarSocio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_BuscarSocio.Location = new System.Drawing.Point(491, 158);
            this.button_BuscarSocio.Name = "button_BuscarSocio";
            this.button_BuscarSocio.Size = new System.Drawing.Size(260, 97);
            this.button_BuscarSocio.TabIndex = 4;
            this.button_BuscarSocio.Text = "Buscar";
            this.button_BuscarSocio.UseVisualStyleBackColor = true;
            this.button_BuscarSocio.Click += new System.EventHandler(this.button_BuscarSocio_Click);
            // 
            // FrmCobroCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_BuscarSocio);
            this.Controls.Add(this.button_CobrarCuota);
            this.Controls.Add(this.textBox_NumeroSocio);
            this.Controls.Add(this.lb_BusquedaSocio);
            this.Controls.Add(this.listBox_SocioBuscado);
            this.Name = "FrmCobroCuota";
            this.Text = "Cobro Cuota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_SocioBuscado;
        private System.Windows.Forms.Label lb_BusquedaSocio;
        public System.Windows.Forms.TextBox textBox_NumeroSocio;
        private System.Windows.Forms.Button button_CobrarCuota;
        private System.Windows.Forms.Button button_BuscarSocio;
        private System.Windows.Forms.Button button1;
    }
}
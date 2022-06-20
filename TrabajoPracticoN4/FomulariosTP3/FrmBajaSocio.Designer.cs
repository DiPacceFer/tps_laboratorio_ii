
namespace FomulariosTP3
{
    partial class FrmBajaSocio
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
            this.button_BuscarSocio = new System.Windows.Forms.Button();
            this.lb_NumeroSocio = new System.Windows.Forms.Label();
            this.txtBox_NumeroSocio = new System.Windows.Forms.TextBox();
            this.listBox_DatosSocio = new System.Windows.Forms.ListBox();
            this.button_Baja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_BuscarSocio
            // 
            this.button_BuscarSocio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_BuscarSocio.Location = new System.Drawing.Point(52, 268);
            this.button_BuscarSocio.Name = "button_BuscarSocio";
            this.button_BuscarSocio.Size = new System.Drawing.Size(225, 131);
            this.button_BuscarSocio.TabIndex = 0;
            this.button_BuscarSocio.Text = "Buscar";
            this.button_BuscarSocio.UseVisualStyleBackColor = true;
            this.button_BuscarSocio.Click += new System.EventHandler(this.button_BuscarSocio_Click);
            // 
            // lb_NumeroSocio
            // 
            this.lb_NumeroSocio.AutoSize = true;
            this.lb_NumeroSocio.Location = new System.Drawing.Point(52, 21);
            this.lb_NumeroSocio.Name = "lb_NumeroSocio";
            this.lb_NumeroSocio.Size = new System.Drawing.Size(151, 25);
            this.lb_NumeroSocio.TabIndex = 1;
            this.lb_NumeroSocio.Text = "Numero de Socio";
            // 
            // txtBox_NumeroSocio
            // 
            this.txtBox_NumeroSocio.Location = new System.Drawing.Point(52, 49);
            this.txtBox_NumeroSocio.Name = "txtBox_NumeroSocio";
            this.txtBox_NumeroSocio.Size = new System.Drawing.Size(150, 31);
            this.txtBox_NumeroSocio.TabIndex = 2;
            this.txtBox_NumeroSocio.Text = "1";
            // 
            // listBox_DatosSocio
            // 
            this.listBox_DatosSocio.FormattingEnabled = true;
            this.listBox_DatosSocio.ItemHeight = 25;
            this.listBox_DatosSocio.Location = new System.Drawing.Point(52, 103);
            this.listBox_DatosSocio.Name = "listBox_DatosSocio";
            this.listBox_DatosSocio.Size = new System.Drawing.Size(736, 104);
            this.listBox_DatosSocio.TabIndex = 3;
            // 
            // button_Baja
            // 
            this.button_Baja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Baja.Location = new System.Drawing.Point(563, 268);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(225, 131);
            this.button_Baja.TabIndex = 4;
            this.button_Baja.Text = "Dar de Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            this.button_Baja.Click += new System.EventHandler(this.button_Baja_Click);
            // 
            // FrmBajaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Baja);
            this.Controls.Add(this.listBox_DatosSocio);
            this.Controls.Add(this.txtBox_NumeroSocio);
            this.Controls.Add(this.lb_NumeroSocio);
            this.Controls.Add(this.button_BuscarSocio);
            this.Name = "FrmBajaSocio";
            this.Text = "Baja Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_BuscarSocio;
        private System.Windows.Forms.Label lb_NumeroSocio;
        private System.Windows.Forms.TextBox txtBox_NumeroSocio;
        private System.Windows.Forms.ListBox listBox_DatosSocio;
        private System.Windows.Forms.Button button_Baja;
    }
}
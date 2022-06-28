
namespace FomulariosTP3
{
    partial class FrmModificarSocio
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
            this.button_BuscarSocio = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBox_SocioBuscado
            // 
            this.listBox_SocioBuscado.FormattingEnabled = true;
            this.listBox_SocioBuscado.ItemHeight = 25;
            this.listBox_SocioBuscado.Location = new System.Drawing.Point(12, 12);
            this.listBox_SocioBuscado.Name = "listBox_SocioBuscado";
            this.listBox_SocioBuscado.Size = new System.Drawing.Size(776, 79);
            this.listBox_SocioBuscado.TabIndex = 0;
            // 
            // lb_BusquedaSocio
            // 
            this.lb_BusquedaSocio.AutoSize = true;
            this.lb_BusquedaSocio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_BusquedaSocio.Location = new System.Drawing.Point(12, 105);
            this.lb_BusquedaSocio.Name = "lb_BusquedaSocio";
            this.lb_BusquedaSocio.Size = new System.Drawing.Size(151, 25);
            this.lb_BusquedaSocio.TabIndex = 2;
            this.lb_BusquedaSocio.Text = "Numero de Socio";
            // 
            // textBox_NumeroSocio
            // 
            this.textBox_NumeroSocio.Location = new System.Drawing.Point(12, 133);
            this.textBox_NumeroSocio.Name = "textBox_NumeroSocio";
            this.textBox_NumeroSocio.Size = new System.Drawing.Size(150, 31);
            this.textBox_NumeroSocio.TabIndex = 3;
            this.textBox_NumeroSocio.Text = "1";
            this.textBox_NumeroSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_BuscarSocio
            // 
            this.button_BuscarSocio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_BuscarSocio.Location = new System.Drawing.Point(214, 105);
            this.button_BuscarSocio.Name = "button_BuscarSocio";
            this.button_BuscarSocio.Size = new System.Drawing.Size(574, 59);
            this.button_BuscarSocio.TabIndex = 5;
            this.button_BuscarSocio.Text = "Buscar";
            this.button_BuscarSocio.UseVisualStyleBackColor = true;
            this.button_BuscarSocio.Click += new System.EventHandler(this.button_BuscarSocio_Click);
            // 
            // button_Modificar
            // 
            this.button_Modificar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Modificar.Location = new System.Drawing.Point(378, 265);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(410, 71);
            this.button_Modificar.TabIndex = 6;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.button_Modificar_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(12, 220);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(269, 31);
            this.textBox_Nombre.TabIndex = 17;
            this.textBox_Nombre.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(287, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(287, 220);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(269, 31);
            this.textBox_Apellido.TabIndex = 19;
            this.textBox_Apellido.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(561, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "DNI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Dni
            // 
            this.textBox_Dni.Location = new System.Drawing.Point(561, 220);
            this.textBox_Dni.Name = "textBox_Dni";
            this.textBox_Dni.Size = new System.Drawing.Size(227, 31);
            this.textBox_Dni.TabIndex = 21;
            this.textBox_Dni.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de Nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_FechaNac
            // 
            this.dateTimePicker_FechaNac.Location = new System.Drawing.Point(12, 305);
            this.dateTimePicker_FechaNac.Name = "dateTimePicker_FechaNac";
            this.dateTimePicker_FechaNac.Size = new System.Drawing.Size(343, 31);
            this.dateTimePicker_FechaNac.TabIndex = 23;
            // 
            // FrmModificarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.dateTimePicker_FechaNac);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_BuscarSocio);
            this.Controls.Add(this.textBox_Dni);
            this.Controls.Add(this.textBox_NumeroSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_BusquedaSocio);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.listBox_SocioBuscado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmModificarSocio";
            this.Text = "Modificar datos de socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_SocioBuscado;
        private System.Windows.Forms.Label lb_BusquedaSocio;
        public System.Windows.Forms.TextBox textBox_NumeroSocio;
        private System.Windows.Forms.Button button_BuscarSocio;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNac;
    }
}
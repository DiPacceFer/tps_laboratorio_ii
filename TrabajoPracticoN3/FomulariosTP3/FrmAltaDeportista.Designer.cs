
namespace FomulariosTP3
{
    partial class FrmAltaDeportista
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
            this.lb_Deporte = new System.Windows.Forms.Label();
            this.comboBox_Deporte = new System.Windows.Forms.ComboBox();
            this.lb_Categoria = new System.Windows.Forms.Label();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_Deporte
            // 
            this.lb_Deporte.AutoSize = true;
            this.lb_Deporte.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_Deporte.Location = new System.Drawing.Point(333, 340);
            this.lb_Deporte.Name = "lb_Deporte";
            this.lb_Deporte.Size = new System.Drawing.Size(77, 25);
            this.lb_Deporte.TabIndex = 16;
            this.lb_Deporte.Text = "Deporte";
            // 
            // comboBox_Deporte
            // 
            this.comboBox_Deporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Deporte.FormattingEnabled = true;
            this.comboBox_Deporte.Location = new System.Drawing.Point(333, 368);
            this.comboBox_Deporte.Name = "comboBox_Deporte";
            this.comboBox_Deporte.Size = new System.Drawing.Size(182, 33);
            this.comboBox_Deporte.TabIndex = 17;
            // 
            // lb_Categoria
            // 
            this.lb_Categoria.AutoSize = true;
            this.lb_Categoria.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_Categoria.Location = new System.Drawing.Point(333, 404);
            this.lb_Categoria.Name = "lb_Categoria";
            this.lb_Categoria.Size = new System.Drawing.Size(88, 25);
            this.lb_Categoria.TabIndex = 18;
            this.lb_Categoria.Text = "Categoria";
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(333, 432);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(182, 33);
            this.comboBox_Categoria.TabIndex = 19;
            // 
            // FrmAltaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 512);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.lb_Categoria);
            this.Controls.Add(this.comboBox_Deporte);
            this.Controls.Add(this.lb_Deporte);
            this.Name = "FrmAltaDeportista";
            this.Text = "Alta Deportista";
            this.Controls.SetChildIndex(this.txbx_Nombre, 0);
            this.Controls.SetChildIndex(this.textBox_Apellido, 0);
            this.Controls.SetChildIndex(this.textBox_DNI, 0);
            this.Controls.SetChildIndex(this.dateTimePicker_FechaNac, 0);
            this.Controls.SetChildIndex(this.button_Alta, 0);
            this.Controls.SetChildIndex(this.lb_Deporte, 0);
            this.Controls.SetChildIndex(this.comboBox_Deporte, 0);
            this.Controls.SetChildIndex(this.lb_Categoria, 0);
            this.Controls.SetChildIndex(this.comboBox_Categoria, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Deporte;
        private System.Windows.Forms.ComboBox comboBox_Deporte;
        private System.Windows.Forms.Label lb_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
    }
}
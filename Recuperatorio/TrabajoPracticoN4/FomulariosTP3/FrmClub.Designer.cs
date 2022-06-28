
namespace FomulariosTP3
{
    partial class FrmClub
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrarDeportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.cobroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeportistaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeportistaToolStripMenuItem
            // 
            this.altaDeportistaToolStripMenuItem.Name = "altaDeportistaToolStripMenuItem";
            this.altaDeportistaToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.altaDeportistaToolStripMenuItem.Text = "Modificar datos";
            this.altaDeportistaToolStripMenuItem.Click += new System.EventHandler(this.altaDeportistaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalSociosToolStripMenuItem,
            this.deporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // totalSociosToolStripMenuItem
            // 
            this.totalSociosToolStripMenuItem.Name = "totalSociosToolStripMenuItem";
            this.totalSociosToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.totalSociosToolStripMenuItem.Text = "Total Socios";
            this.totalSociosToolStripMenuItem.Click += new System.EventHandler(this.totalSociosToolStripMenuItem_Click);
            // 
            // deporteToolStripMenuItem
            // 
            this.deporteToolStripMenuItem.Name = "deporteToolStripMenuItem";
            this.deporteToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.deporteToolStripMenuItem.Text = "Total Pagos";
            this.deporteToolStripMenuItem.Click += new System.EventHandler(this.deporteToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socioToolStripMenuItem,
            this.deportistaToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.socioToolStripMenuItem.Text = "Socio";
            this.socioToolStripMenuItem.Click += new System.EventHandler(this.socioToolStripMenuItem_Click);
            // 
            // deportistaToolStripMenuItem
            // 
            this.deportistaToolStripMenuItem.Name = "deportistaToolStripMenuItem";
            this.deportistaToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.deportistaToolStripMenuItem.Text = "Deportista";
            this.deportistaToolStripMenuItem.Click += new System.EventHandler(this.deportistaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // cobroToolStripMenuItem
            // 
            this.cobroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuotaToolStripMenuItem,
            this.cobrarDeportistaToolStripMenuItem});
            this.cobroToolStripMenuItem.Name = "cobroToolStripMenuItem";
            this.cobroToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.cobroToolStripMenuItem.Text = "Cobro";
            // 
            // cuotaToolStripMenuItem
            // 
            this.cuotaToolStripMenuItem.Name = "cuotaToolStripMenuItem";
            this.cuotaToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.cuotaToolStripMenuItem.Text = "Cobrar Socio";
            this.cuotaToolStripMenuItem.Click += new System.EventHandler(this.cuotaToolStripMenuItem_Click);
            // 
            // cobrarDeportistaToolStripMenuItem
            // 
            this.cobrarDeportistaToolStripMenuItem.Name = "cobrarDeportistaToolStripMenuItem";
            this.cobrarDeportistaToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.cobrarDeportistaToolStripMenuItem.Text = "Cobrar Deportista";
            this.cobrarDeportistaToolStripMenuItem.Click += new System.EventHandler(this.cobrarDeportistaToolStripMenuItem_Click);
            // 
            // FrmClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacific Railways Athletic Club";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClub_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrarDeportistaToolStripMenuItem;
    }
}


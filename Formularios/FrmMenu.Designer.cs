namespace TheDogHouse.Formularios
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsDomicilio = new System.Windows.Forms.ToolStripButton();
            this.TsAdoptamte = new System.Windows.Forms.ToolStripButton();
            this.TsEmpleado = new System.Windows.Forms.ToolStripButton();
            this.TsMascota = new System.Windows.Forms.ToolStripButton();
            this.TsSucursal = new System.Windows.Forms.ToolStripButton();
            this.TsAdopcion = new System.Windows.Forms.ToolStripButton();
            this.TsDonacion = new System.Windows.Forms.ToolStripButton();
            this.TsCargo = new System.Windows.Forms.ToolStripButton();
            this.TsVoluntario = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(114, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 351);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsDomicilio,
            this.TsAdoptamte,
            this.TsEmpleado,
            this.TsMascota,
            this.TsSucursal,
            this.TsAdopcion,
            this.TsDonacion,
            this.TsCargo,
            this.TsVoluntario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(107, 351);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsDomicilio
            // 
            this.TsDomicilio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsDomicilio.Image = ((System.Drawing.Image)(resources.GetObject("TsDomicilio.Image")));
            this.TsDomicilio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsDomicilio.Name = "TsDomicilio";
            this.TsDomicilio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsDomicilio.Size = new System.Drawing.Size(106, 30);
            this.TsDomicilio.Text = "DOMICILIO";
            this.TsDomicilio.Click += new System.EventHandler(this.TsDomicilio_Click);
            // 
            // TsAdoptamte
            // 
            this.TsAdoptamte.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TsAdoptamte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsAdoptamte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TsAdoptamte.Name = "TsAdoptamte";
            this.TsAdoptamte.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsAdoptamte.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TsAdoptamte.Size = new System.Drawing.Size(96, 30);
            this.TsAdoptamte.Text = "ADOPTANTE";
            this.TsAdoptamte.Click += new System.EventHandler(this.TsAdoptamte_Click);
            // 
            // TsEmpleado
            // 
            this.TsEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsEmpleado.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.TsEmpleado.Name = "TsEmpleado";
            this.TsEmpleado.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TsEmpleado.Size = new System.Drawing.Size(76, 30);
            this.TsEmpleado.Text = "EMPLEADO";
            this.TsEmpleado.Click += new System.EventHandler(this.TsEmpleado_Click);
            // 
            // TsMascota
            // 
            this.TsMascota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsMascota.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TsMascota.Name = "TsMascota";
            this.TsMascota.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsMascota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TsMascota.Size = new System.Drawing.Size(100, 30);
            this.TsMascota.Text = "MASCOTA";
            this.TsMascota.Click += new System.EventHandler(this.TsMascota_Click);
            // 
            // TsSucursal
            // 
            this.TsSucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsSucursal.Image = ((System.Drawing.Image)(resources.GetObject("TsSucursal.Image")));
            this.TsSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsSucursal.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.TsSucursal.Name = "TsSucursal";
            this.TsSucursal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsSucursal.Size = new System.Drawing.Size(106, 30);
            this.TsSucursal.Text = "SUCURSAL";
            this.TsSucursal.Click += new System.EventHandler(this.TsSucursal_Click);
            // 
            // TsAdopcion
            // 
            this.TsAdopcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsAdopcion.Image = ((System.Drawing.Image)(resources.GetObject("TsAdopcion.Image")));
            this.TsAdopcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsAdopcion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.TsAdopcion.Name = "TsAdopcion";
            this.TsAdopcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsAdopcion.Size = new System.Drawing.Size(106, 30);
            this.TsAdopcion.Text = "ADOPCION";
            // 
            // TsDonacion
            // 
            this.TsDonacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsDonacion.Image = ((System.Drawing.Image)(resources.GetObject("TsDonacion.Image")));
            this.TsDonacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsDonacion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.TsDonacion.Name = "TsDonacion";
            this.TsDonacion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsDonacion.Size = new System.Drawing.Size(106, 30);
            this.TsDonacion.Text = "DONACION";
            this.TsDonacion.Click += new System.EventHandler(this.TsDonacion_Click);
            // 
            // TsCargo
            // 
            this.TsCargo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsCargo.Image = ((System.Drawing.Image)(resources.GetObject("TsCargo.Image")));
            this.TsCargo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsCargo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.TsCargo.Name = "TsCargo";
            this.TsCargo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsCargo.Size = new System.Drawing.Size(106, 30);
            this.TsCargo.Text = "CARGO";
            this.TsCargo.Click += new System.EventHandler(this.TsCargo_Click);
            // 
            // TsVoluntario
            // 
            this.TsVoluntario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsVoluntario.Image = ((System.Drawing.Image)(resources.GetObject("TsVoluntario.Image")));
            this.TsVoluntario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsVoluntario.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.TsVoluntario.Name = "TsVoluntario";
            this.TsVoluntario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TsVoluntario.Size = new System.Drawing.Size(87, 30);
            this.TsVoluntario.Text = "VOLUNTARIO";
            this.TsVoluntario.Click += new System.EventHandler(this.TsVoluntario_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 351);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsAdoptamte;
        private System.Windows.Forms.ToolStripButton TsEmpleado;
        private System.Windows.Forms.ToolStripButton TsMascota;
        private System.Windows.Forms.ToolStripButton TsDomicilio;
        private System.Windows.Forms.ToolStripButton TsSucursal;
        private System.Windows.Forms.ToolStripButton TsAdopcion;
        private System.Windows.Forms.ToolStripButton TsDonacion;
        private System.Windows.Forms.ToolStripButton TsCargo;
        private System.Windows.Forms.ToolStripButton TsVoluntario;
    }
}
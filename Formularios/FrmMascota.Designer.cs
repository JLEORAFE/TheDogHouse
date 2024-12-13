namespace TheDogHouse.Formularios
{
    partial class FrmMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMascota));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DtpFechaIng = new System.Windows.Forms.DateTimePicker();
            this.TxtRaza = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumMasc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBuscar = new System.Windows.Forms.ToolStripButton();
            this.TsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.TsEliminar = new System.Windows.Forms.ToolStripButton();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(179, 167);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 27);
            this.BtnBuscar.TabIndex = 51;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtpFechaIng
            // 
            this.DtpFechaIng.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpFechaIng.Location = new System.Drawing.Point(387, 88);
            this.DtpFechaIng.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaIng.Name = "DtpFechaIng";
            this.DtpFechaIng.Size = new System.Drawing.Size(275, 27);
            this.DtpFechaIng.TabIndex = 50;
            // 
            // TxtRaza
            // 
            this.TxtRaza.Location = new System.Drawing.Point(268, 261);
            this.TxtRaza.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRaza.Name = "TxtRaza";
            this.TxtRaza.Size = new System.Drawing.Size(170, 27);
            this.TxtRaza.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Raza";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(39, 358);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEdad.MaxLength = 3;
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(82, 27);
            this.TxtEdad.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Edad";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(330, 358);
            this.TxtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(122, 27);
            this.TxtPeso.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Peso";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(172, 358);
            this.TxtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(123, 27);
            this.TxtAltura.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Altura";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(39, 261);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(170, 27);
            this.TxtNombre.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "FECHA DE INGRESO";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(43, 167);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(105, 27);
            this.TxtId.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID";
            // 
            // TxtNumMasc
            // 
            this.TxtNumMasc.Location = new System.Drawing.Point(343, 167);
            this.TxtNumMasc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumMasc.Name = "TxtNumMasc";
            this.TxtNumMasc.Size = new System.Drawing.Size(173, 27);
            this.TxtNumMasc.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(337, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 45;
            this.label11.Text = "NUM.MASCOTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 37;
            this.label1.Text = "MASCOTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.toolStrip1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsGuardar,
            this.TsBuscar,
            this.TsLimpiar,
            this.TsEliminar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(36, 10, 0, 10);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(682, 62);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsGuardar
            // 
            this.TsGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.TsGuardar.ForeColor = System.Drawing.Color.White;
            this.TsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TsGuardar.Image")));
            this.TsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsGuardar.Name = "TsGuardar";
            this.TsGuardar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TsGuardar.Size = new System.Drawing.Size(84, 39);
            this.TsGuardar.Text = "Guardar";
            this.TsGuardar.Click += new System.EventHandler(this.TsGuardar_Click);
            // 
            // TsBuscar
            // 
            this.TsBuscar.ForeColor = System.Drawing.Color.White;
            this.TsBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TsBuscar.Image")));
            this.TsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBuscar.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.TsBuscar.Name = "TsBuscar";
            this.TsBuscar.Size = new System.Drawing.Size(77, 39);
            this.TsBuscar.Text = "Buscar";
            this.TsBuscar.Click += new System.EventHandler(this.TsBuscar_Click);
            // 
            // TsLimpiar
            // 
            this.TsLimpiar.ForeColor = System.Drawing.Color.White;
            this.TsLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("TsLimpiar.Image")));
            this.TsLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsLimpiar.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.TsLimpiar.Name = "TsLimpiar";
            this.TsLimpiar.Size = new System.Drawing.Size(80, 39);
            this.TsLimpiar.Text = "Limpiar";
            this.TsLimpiar.Click += new System.EventHandler(this.TsLimpiar_Click);
            // 
            // TsEliminar
            // 
            this.TsEliminar.ForeColor = System.Drawing.Color.White;
            this.TsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TsEliminar.Image")));
            this.TsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsEliminar.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.TsEliminar.Name = "TsEliminar";
            this.TsEliminar.Size = new System.Drawing.Size(85, 39);
            this.TsEliminar.Text = "Eliminar";
            this.TsEliminar.Click += new System.EventHandler(this.TsEliminar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.Location = new System.Drawing.Point(525, 352);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(108, 37);
            this.BtnImprimir.TabIndex = 98;
            this.BtnImprimir.Text = "IMPRIMIR";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 419);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtpFechaIng);
            this.Controls.Add(this.TxtRaza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumMasc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker DtpFechaIng;
        private System.Windows.Forms.TextBox TxtRaza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumMasc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsGuardar;
        private System.Windows.Forms.ToolStripButton TsBuscar;
        private System.Windows.Forms.ToolStripButton TsLimpiar;
        private System.Windows.Forms.ToolStripButton TsEliminar;
        private System.Windows.Forms.Button BtnImprimir;
    }
}
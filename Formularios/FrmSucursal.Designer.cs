namespace TheDogHouse.Formularios
{
    partial class FrmSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucursal));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtHorario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumSuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CbDomicilio = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TsGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBuscar = new System.Windows.Forms.ToolStripButton();
            this.TsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.TsEliminar = new System.Windows.Forms.ToolStripButton();
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
            this.BtnBuscar.Location = new System.Drawing.Point(179, 185);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 27);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(387, 279);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(170, 27);
            this.TxtTelefono.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 65;
            this.label8.Text = "Telefono";
            // 
            // TxtHorario
            // 
            this.TxtHorario.Location = new System.Drawing.Point(43, 357);
            this.TxtHorario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHorario.MaxLength = 300;
            this.TxtHorario.Name = "TxtHorario";
            this.TxtHorario.Size = new System.Drawing.Size(227, 27);
            this.TxtHorario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "Horario";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(39, 279);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(318, 27);
            this.TxtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nombre";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(43, 185);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(105, 27);
            this.TxtId.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "ID";
            // 
            // TxtNumSuc
            // 
            this.TxtNumSuc.Location = new System.Drawing.Point(389, 185);
            this.TxtNumSuc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumSuc.Name = "TxtNumSuc";
            this.TxtNumSuc.Size = new System.Drawing.Size(173, 27);
            this.TxtNumSuc.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 58;
            this.label1.Text = "SUCURSALES";
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
            this.toolStrip1.Size = new System.Drawing.Size(683, 62);
            this.toolStrip1.TabIndex = 57;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CbDomicilio
            // 
            this.CbDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDomicilio.FormattingEnabled = true;
            this.CbDomicilio.Location = new System.Drawing.Point(352, 357);
            this.CbDomicilio.Name = "CbDomicilio";
            this.CbDomicilio.Size = new System.Drawing.Size(205, 27);
            this.CbDomicilio.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(348, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "Domicilio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 64;
            this.label11.Text = "NUM.SUCURSAL";
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
            // FrmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 444);
            this.Controls.Add(this.CbDomicilio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtHorario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumSuc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSucursal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtHorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumSuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsGuardar;
        private System.Windows.Forms.ToolStripButton TsBuscar;
        private System.Windows.Forms.ToolStripButton TsLimpiar;
        private System.Windows.Forms.ToolStripButton TsEliminar;
        private System.Windows.Forms.ComboBox CbDomicilio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
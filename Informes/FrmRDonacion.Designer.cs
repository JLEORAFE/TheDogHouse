namespace TheDogHouse.Informes
{
    partial class FrmRDonacion
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
            this.CbDonacion = new System.Windows.Forms.ComboBox();
            this.ChTodo = new System.Windows.Forms.CheckBox();
            this.rVDonacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbDonacion
            // 
            this.CbDonacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDonacion.FormattingEnabled = true;
            this.CbDonacion.Location = new System.Drawing.Point(236, 31);
            this.CbDonacion.Name = "CbDonacion";
            this.CbDonacion.Size = new System.Drawing.Size(247, 21);
            this.CbDonacion.TabIndex = 10;
            // 
            // ChTodo
            // 
            this.ChTodo.AutoSize = true;
            this.ChTodo.Location = new System.Drawing.Point(173, 33);
            this.ChTodo.Name = "ChTodo";
            this.ChTodo.Size = new System.Drawing.Size(57, 17);
            this.ChTodo.TabIndex = 9;
            this.ChTodo.Text = "TODO";
            this.ChTodo.UseVisualStyleBackColor = true;
            // 
            // rVDonacion
            // 
            this.rVDonacion.LocalReport.ReportEmbeddedResource = "p_Blockbuster.Informes.RMunicipio.rdlc";
            this.rVDonacion.Location = new System.Drawing.Point(12, 92);
            this.rVDonacion.Name = "rVDonacion";
            this.rVDonacion.ServerReport.BearerToken = null;
            this.rVDonacion.Size = new System.Drawing.Size(776, 329);
            this.rVDonacion.TabIndex = 8;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(517, 25);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(108, 34);
            this.BtnAceptar.TabIndex = 81;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmRDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CbDonacion);
            this.Controls.Add(this.ChTodo);
            this.Controls.Add(this.rVDonacion);
            this.Name = "FrmRDonacion";
            this.Text = "FrmRDonacion";
            this.Load += new System.EventHandler(this.FrmRDonacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbDonacion;
        private System.Windows.Forms.CheckBox ChTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rVDonacion;
        private System.Windows.Forms.Button BtnAceptar;
    }
}
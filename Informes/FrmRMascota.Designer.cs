namespace TheDogHouse.Informes
{
    partial class FrmRMascota
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CbMascota = new System.Windows.Forms.ComboBox();
            this.ChTodo = new System.Windows.Forms.CheckBox();
            this.rVMascota = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(517, 27);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(108, 34);
            this.BtnAceptar.TabIndex = 85;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CbMascota
            // 
            this.CbMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMascota.FormattingEnabled = true;
            this.CbMascota.Location = new System.Drawing.Point(236, 33);
            this.CbMascota.Name = "CbMascota";
            this.CbMascota.Size = new System.Drawing.Size(247, 21);
            this.CbMascota.TabIndex = 84;
            // 
            // ChTodo
            // 
            this.ChTodo.AutoSize = true;
            this.ChTodo.Location = new System.Drawing.Point(173, 35);
            this.ChTodo.Name = "ChTodo";
            this.ChTodo.Size = new System.Drawing.Size(57, 17);
            this.ChTodo.TabIndex = 83;
            this.ChTodo.Text = "TODO";
            this.ChTodo.UseVisualStyleBackColor = true;
            // 
            // rVMascota
            // 
            this.rVMascota.LocalReport.ReportEmbeddedResource = "p_Blockbuster.Informes.RMunicipio.rdlc";
            this.rVMascota.Location = new System.Drawing.Point(12, 94);
            this.rVMascota.Name = "rVMascota";
            this.rVMascota.ServerReport.BearerToken = null;
            this.rVMascota.Size = new System.Drawing.Size(776, 329);
            this.rVMascota.TabIndex = 82;
            // 
            // FrmRMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CbMascota);
            this.Controls.Add(this.ChTodo);
            this.Controls.Add(this.rVMascota);
            this.Name = "FrmRMascota";
            this.Text = "FrmRMascota";
            this.Load += new System.EventHandler(this.FrmRMascota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CbMascota;
        private System.Windows.Forms.CheckBox ChTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rVMascota;
    }
}
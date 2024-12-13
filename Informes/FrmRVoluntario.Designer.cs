namespace TheDogHouse.Informes
{
    partial class FrmRVoluntario
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
            this.CbVoluntario = new System.Windows.Forms.ComboBox();
            this.ChTodo = new System.Windows.Forms.CheckBox();
            this.rVVoluntario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(496, 29);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(108, 23);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CbVoluntario
            // 
            this.CbVoluntario.FormattingEnabled = true;
            this.CbVoluntario.Location = new System.Drawing.Point(236, 31);
            this.CbVoluntario.Name = "CbVoluntario";
            this.CbVoluntario.Size = new System.Drawing.Size(247, 21);
            this.CbVoluntario.TabIndex = 6;
            // 
            // ChTodo
            // 
            this.ChTodo.AutoSize = true;
            this.ChTodo.Location = new System.Drawing.Point(173, 33);
            this.ChTodo.Name = "ChTodo";
            this.ChTodo.Size = new System.Drawing.Size(57, 17);
            this.ChTodo.TabIndex = 5;
            this.ChTodo.Text = "TODO";
            this.ChTodo.UseVisualStyleBackColor = true;
            // 
            // rVVoluntario
            // 
            this.rVVoluntario.LocalReport.ReportEmbeddedResource = "p_Blockbuster.Informes.RMunicipio.rdlc";
            this.rVVoluntario.Location = new System.Drawing.Point(12, 92);
            this.rVVoluntario.Name = "rVVoluntario";
            this.rVVoluntario.ServerReport.BearerToken = null;
            this.rVVoluntario.Size = new System.Drawing.Size(776, 329);
            this.rVVoluntario.TabIndex = 4;
            // 
            // FrmRVoluntario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CbVoluntario);
            this.Controls.Add(this.ChTodo);
            this.Controls.Add(this.rVVoluntario);
            this.Name = "FrmRVoluntario";
            this.Text = "FrmRVoluntario";
            this.Load += new System.EventHandler(this.FrmRVoluntario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CbVoluntario;
        private System.Windows.Forms.CheckBox ChTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rVVoluntario;
    }
}
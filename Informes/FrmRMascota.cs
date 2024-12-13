using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TheDogHouse.Clases;

namespace TheDogHouse.Informes
{
    public partial class FrmRMascota : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmRMascota()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmRMascota_Load(object sender, EventArgs e)
        {
            cargarcb();
        }

        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Mascota";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            CbMascota.DisplayMember = "Nombre";
            CbMascota.ValueMember = "Num_Masc";
            CbMascota.DataSource = dt;
        }

        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (ChTodo.Checked == true)
            {
                consulta = "SELECT * FROM vMascota";
                ChTodo.Checked = false;
            }
            else
            {
                consulta = $"SELECT * FROM vMascota WHERE Num_Masc = {CbMascota.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rVMascota.LocalReport.DataSources.Clear();
            this.rVMascota.LocalReport.ReportEmbeddedResource = "TheDogHouse.Informes.RMascota.rdlc";
            ReportDataSource r = new ReportDataSource("DsrMascota", dt);
            this.rVMascota.LocalReport.DataSources.Add(r);
            this.rVMascota.RefreshReport();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}

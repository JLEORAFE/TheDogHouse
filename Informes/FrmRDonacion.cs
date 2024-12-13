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
    public partial class FrmRDonacion : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public FrmRDonacion()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmRDonacion_Load(object sender, EventArgs e)
        {
            cargarcb();
        }

        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Donacion";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            CbDonacion.DisplayMember = "Nombre";
            CbDonacion.ValueMember = "Folio";
            CbDonacion.DataSource = dt;
        }

        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (ChTodo.Checked == true)
            {
                consulta = "SELECT * FROM vDonacion";
                ChTodo.Checked = false;
            }
            else
            {
                consulta = $"SELECT * FROM vDonacion WHERE Folio = {CbDonacion.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rVDonacion.LocalReport.DataSources.Clear();
            this.rVDonacion.LocalReport.ReportEmbeddedResource = "TheDogHouse.Informes.RDonacion.rdlc";
            ReportDataSource r = new ReportDataSource("DsrDonacion", dt);
            this.rVDonacion.LocalReport.DataSources.Add(r);
            this.rVDonacion.RefreshReport();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}

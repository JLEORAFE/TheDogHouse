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
    public partial class FrmRVoluntario : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public FrmRVoluntario()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmRVoluntario_Load(object sender, EventArgs e)
        {
            cargarcb();
        }

        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Voluntario";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            CbVoluntario.DisplayMember = "Nombre";
            CbVoluntario.ValueMember = "Num_Volun";
            CbVoluntario.DataSource = dt;
        }

        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (ChTodo.Checked == true)
            {
                consulta = "SELECT * FROM vVoluntario";
                ChTodo.Checked = false;
            }
            else
            {
                consulta = $"SELECT * FROM vVoluntario WHERE Num_Volun = {CbVoluntario.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rVVoluntario.LocalReport.DataSources.Clear();
            this.rVVoluntario.LocalReport.ReportEmbeddedResource = "TheDogHouse.Informes.RVoluntario.rdlc";
            ReportDataSource r = new ReportDataSource("DsvVoluntario", dt);
            this.rVVoluntario.LocalReport.DataSources.Add(r);
            this.rVVoluntario.RefreshReport();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}

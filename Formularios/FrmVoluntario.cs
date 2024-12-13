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
using TheDogHouse.Busquedas;
using TheDogHouse.Clases;

namespace TheDogHouse.Formularios
{
    public partial class FrmVoluntario : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmVoluntario()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmVoluntario_Load(object sender, EventArgs e)
        {
            cargarcbC();
            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Voluntario").ToString();
        }

        void limpiar()
        {
            TxtNumVolun.Clear();
            TxtNombre.Clear();
            TxtApellidoP.Clear();
            TxtApellidoM.Clear();
            DtpFechaIns.Value = DateTime.Today;
            TxtEdad.Clear();
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Voluntario").ToString();

        }

        void cargarcbC()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Cargo";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            CbCargo.DisplayMember = "Nombre";
            CbCargo.ValueMember = "Id";
            CbCargo.DataSource = dt;
        }

        bool encontrar()
        {
            bool b = false;
            int Id = int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Voluntario WHERE Id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                b = true;
            }
            else
            {
                b = false;
            }
            con.Close();
            return b;
        }

        private void TsGuardar_Click(object sender, EventArgs e)
        {
            Voluntario v = new Voluntario();
            v.Id = int.Parse(TxtId.Text);
            v.NumVol = int.Parse(TxtNumVolun.Text);
            v.Nombre = TxtNombre.Text;
            v.ApellidoP = TxtApellidoP.Text;
            v.ApellidoM = TxtApellidoM.Text;
            string FechaInscripcion = DtpFechaIns.Value.Year + "/" + DtpFechaIns.Value.Month + "/" + DtpFechaIns.Value.Day;
            v.FechaIns = FechaInscripcion;
            v.edad = int.Parse(TxtEdad.Text);
            v.IdCar = int.Parse(CbCargo.SelectedValue.ToString());

            if (encontrar() == true)
            {
                MessageBox.Show(v.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(v.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaVoluntario x = new FrmBusquedaVoluntario();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgVoluntario.SelectedRows[0].Cells["Id"].Value.ToString();

                TxtNumVolun.Text = x.DgVoluntario.SelectedRows[0].Cells["Num_Volun"].Value.ToString();

                DtpFechaIns.Value = DateTime.Parse(x.DgVoluntario.SelectedRows[0].Cells["Fecha_Inscrip"].Value.ToString());
                
                TxtNombre.Text = x.DgVoluntario.SelectedRows[0].Cells["Nombre"].Value.ToString();

                TxtApellidoP.Text = x.DgVoluntario.SelectedRows[0].Cells["ApellidoP"].Value.ToString();

                TxtApellidoM.Text = x.DgVoluntario.SelectedRows[0].Cells["ApellidoM"].Value.ToString();

                TxtEdad.Text = x.DgVoluntario.SelectedRows[0].Cells["Edad"].Value.ToString();

                CbCargo.SelectedValue = int.Parse(x.DgVoluntario.SelectedRows[0].Cells["Id_Cargo"].Value.ToString());
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Voluntario v = new Voluntario();
            v.Id = int.Parse(TxtId.Text);
            MessageBox.Show(v.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Voluntario WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtNumVolun.Text = reader["Num_Volun"].ToString();
                DtpFechaIns.Value = DateTime.Parse(reader["Fecha_Inscrip"].ToString());
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtApellidoP.Text = reader["ApellidoP"].ToString();
                TxtApellidoM.Text = reader["ApellidoM"].ToString();
                TxtEdad.Text = reader["Edad"].ToString();
                CbCargo.SelectedValue = int.Parse(reader["Id_Cargo"].ToString());

            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun Empleado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "0" || TxtId.Text == "")
            {
                MessageBox.Show("ID no valido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Obtener();
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Informes.FrmRVoluntario x = new Informes.FrmRVoluntario();
            x.ShowDialog();
        }
    }
}

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
    public partial class FrmMascota : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmMascota()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Mascota").ToString();

            Herramienta cl = new Herramienta();
            TxtNumMasc.Text = cl.ClaveNumMasc("Num_Masc", "Mascota").ToString();
        }

        void limpiar()
        {
            TxtNumMasc.Clear();
            DtpFechaIng.Value = DateTime.Today;
            TxtNombre.Clear();
            TxtEdad.Clear();
            TxtAltura.Clear();
            TxtPeso.Clear();
            TxtRaza.Clear();
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Mascota").ToString();

            Herramienta cl = new Herramienta();
            TxtNumMasc.Text = cl.ClaveNumMasc("Num_Masc", "Mascota").ToString();
        }

        bool encontrar()
        {
            bool b = false;
            int Id = int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Mascota WHERE Id = {Id}";
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
            Mascota m = new Mascota();

            m.Id = int.Parse(TxtId.Text);

            m.NumMasc = int.Parse(TxtNumMasc.Text);

            string FechaIngreso = DtpFechaIng.Value.Year + "/" + DtpFechaIng.Value.Month + "/" + DtpFechaIng.Value.Day;

            m.FechaIng = FechaIngreso;

            m.Nombre = TxtNombre.Text;

            m.edad = int.Parse(TxtEdad.Text);

            m.Altura = decimal.Parse(TxtAltura.Text);

            m.Peso = decimal.Parse(TxtPeso.Text);

            m.Raza = TxtRaza.Text;

            if (encontrar() == true)
            {
                MessageBox.Show(m.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(m.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaMascota x = new FrmBusquedaMascota();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgMascota.SelectedRows[0].Cells["Id"].Value.ToString();

                DtpFechaIng.Value = DateTime.Parse(x.DgMascota.SelectedRows[0].Cells["Fecha_Ing"].Value.ToString());
                
                TxtNumMasc.Text = x.DgMascota.SelectedRows[0].Cells["Num_Masc"].Value.ToString();

                TxtNombre.Text = x.DgMascota.SelectedRows[0].Cells["Nombre"].Value.ToString();

                TxtEdad.Text = x.DgMascota.SelectedRows[0].Cells["Edad"].Value.ToString();

                TxtAltura.Text = x.DgMascota.SelectedRows[0].Cells["Altura"].Value.ToString();

                TxtPeso.Text = x.DgMascota.SelectedRows[0].Cells["Peso"].Value.ToString();

                TxtRaza.Text = x.DgMascota.SelectedRows[0].Cells["Raza"].Value.ToString();
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            m.Id = int.Parse(TxtId.Text);
            MessageBox.Show(m.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Mascota WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtNumMasc.Text = reader["Num_Masc"].ToString();
                DtpFechaIng.Value = DateTime.Parse(reader["Fecha_Ing"].ToString());
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtEdad.Text = reader["Edad"].ToString();
                TxtAltura.Text = reader["Altura"].ToString();
                TxtPeso.Text = reader["Peso"].ToString();
                TxtRaza.Text = reader["Raza"].ToString();

            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ninguna Mascota", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Informes.FrmRMascota x = new Informes.FrmRMascota();
            x.ShowDialog();
        }
    }
}
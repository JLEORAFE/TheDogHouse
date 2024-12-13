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
    public partial class FrmDonacion : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmDonacion()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmDonacion_Load(object sender, EventArgs e)
        {

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Donacion").ToString();

            Herramienta cl = new Herramienta();
            TxtFolio.Text = cl.Folio("Folio", "Donacion").ToString();
        }

        void limpiar()
        {
            TxtNombre.Clear();
            TxtApellidoP.Clear();
            TxtApellidoM.Clear();
            TxtTDona.Clear();
            TxtDesc.Clear();
            DtpFechaDon.Value = DateTime.Today;
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Donacion").ToString();

            Herramienta cl = new Herramienta();
            TxtFolio.Text = cl.Folio("Folio", "Donacion").ToString();

        }

        bool encontrar()
        {
            bool b = false;
            int Id = int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Donacion WHERE Id = {Id}";
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
            Donacion d = new Donacion();
            d.Id = int.Parse(TxtId.Text);
            d.Folio = int.Parse(TxtFolio.Text);
            string FechaDonacion = DtpFechaDon.Value.Year + "/" + DtpFechaDon.Value.Month + "/" + DtpFechaDon.Value.Day;
            d.FechaDon = FechaDonacion;
            d.Nombre = TxtNombre.Text;
            d.Ap = TxtApellidoP.Text;
            d.Am = TxtApellidoM.Text;
            d.Tidona = TxtTDona.Text;
            d.Des = TxtDesc.Text;

            if (encontrar() == true)
            {
                MessageBox.Show(d.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(d.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaDonacion x = new FrmBusquedaDonacion();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgDonacion.SelectedRows[0].Cells["Id"].Value.ToString();

                TxtFolio.Text = x.DgDonacion.SelectedRows[0].Cells["Folio"].Value.ToString();
                
                DtpFechaDon.Value = DateTime.Parse(x.DgDonacion.SelectedRows[0].Cells["Fecha_Dona"].Value.ToString());
                
                TxtNombre.Text = x.DgDonacion.SelectedRows[0].Cells["Nombre"].Value.ToString();
                
                TxtApellidoP.Text = x.DgDonacion.SelectedRows[0].Cells["ApellidoP"].Value.ToString();
                
                TxtApellidoM.Text = x.DgDonacion.SelectedRows[0].Cells["ApellidoM"].Value.ToString();
                
                TxtTDona.Text = x.DgDonacion.SelectedRows[0].Cells["Tipo_Dona"].Value.ToString();
                
                TxtDesc.Text = x.DgDonacion.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Donacion d = new Donacion();
            d.Id = int.Parse(TxtId.Text);
            MessageBox.Show(d.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Donacion WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtFolio.Text = reader["Folio"].ToString();
                DtpFechaDon.Value = DateTime.Parse(reader["Fecha_Dona"].ToString());
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtApellidoP.Text = reader["ApellidoP"].ToString();
                TxtApellidoM.Text = reader["ApellidoM"].ToString();
                TxtTDona.Text = reader["Tipo_Dona"].ToString();
                TxtDesc.Text = reader["Descripcion"].ToString();

            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun Adoptante", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Informes.FrmRDonacion x = new Informes.FrmRDonacion();
            x.ShowDialog();
        }
    }
}

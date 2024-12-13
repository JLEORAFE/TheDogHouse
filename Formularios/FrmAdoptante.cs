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
using TheDogHouse.Clases;

namespace TheDogHouse.Formularios
{
    public partial class FrmAdoptante : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmAdoptante()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmAdoptante_Load(object sender, EventArgs e)
        {
            cargarcbD();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Adoptante").ToString();

            Herramienta cl = new Herramienta();
            TxtNumAdop.Text = cl.ClaveNumAdop("Num_Adop", "Adoptante").ToString();
        }

        void limpiar()
        {
            TxtApellidoM.Clear();
            TxtApellidoP.Clear();
            TxtCorreo.Clear();
            TxtEdad.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtNumAdop.Clear();
            cargarcbD();
            DtpFechaReg.Value = DateTime.Today;
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Adoptante").ToString();

            Herramienta cl = new Herramienta();
            TxtNumAdop.Text = cl.ClaveNumAdop("Num_Adop", "Adoptante").ToString();
        }

        void cargarcbD()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Domicilio";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            CbDomicilio.DisplayMember = "Colonia";
            CbDomicilio.ValueMember = "Id";
            CbDomicilio.DataSource = dt;
        }

        bool encontrar()
        {
            bool b = false;
            int Id= int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Adoptante WHERE Id = {Id}";
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
            Adoptante a = new Adoptante();
            a.Id = int.Parse(TxtId.Text);
            a.NumAdop = int.Parse(TxtNumAdop.Text);
            string FechaRegistro = DtpFechaReg.Value.Year + "/" + DtpFechaReg.Value.Month + "/" + DtpFechaReg.Value.Day;
            a.FechaReg = FechaRegistro;
            a.Nombre = TxtNombre.Text;
            a.ApellidoP = TxtApellidoP.Text;
            a.ApellidoM = TxtApellidoM.Text;
            a.edad = int.Parse(TxtEdad.Text);
            a.correo = TxtCorreo.Text;
            a.Telefono = TxtTelefono.Text;
            a.IdDomicilio = int.Parse(CbDomicilio.SelectedValue.ToString());

            if (encontrar() == true)
            {
                MessageBox.Show(a.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(a.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.FrmBusquedaAdoptante x = new Busquedas.FrmBusquedaAdoptante();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgAdoptante.SelectedRows[0].Cells["Id"].Value.ToString();
                TxtNumAdop.Text = x.DgAdoptante.SelectedRows[0].Cells["Num_Adop"].Value.ToString();
                DtpFechaReg.Value = DateTime.Parse(x.DgAdoptante.SelectedRows[0].Cells["Fecha_Reg"].Value.ToString());
                TxtNombre.Text = x.DgAdoptante.SelectedRows[0].Cells["Nombre"].Value.ToString();
                TxtApellidoP.Text = x.DgAdoptante.SelectedRows[0].Cells["ApellidoP"].Value.ToString();
                TxtApellidoM.Text = x.DgAdoptante.SelectedRows[0].Cells["ApellidoM"].Value.ToString();
                TxtEdad.Text = x.DgAdoptante.SelectedRows[0].Cells["Edad"].Value.ToString();
                TxtCorreo.Text = x.DgAdoptante.SelectedRows[0].Cells["Correo"].Value.ToString();
                TxtTelefono.Text = x.DgAdoptante.SelectedRows[0].Cells["Telefono"].Value.ToString();
                CbDomicilio.SelectedValue = int.Parse(x.DgAdoptante.SelectedRows[0].Cells["Id_Domicilio"].Value.ToString());
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Adoptante a = new Adoptante();
            a.Id = int.Parse(TxtId.Text);
            MessageBox.Show(a.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Adoptante WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtNumAdop.Text = reader["Num_Adop"].ToString();
                DtpFechaReg.Value = DateTime.Parse(reader["Fecha_Reg"].ToString());
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtApellidoP.Text = reader["ApellidoP"].ToString();
                TxtApellidoM.Text = reader["ApellidoM"].ToString();
                TxtEdad.Text = reader["Edad"].ToString();
                TxtCorreo.Text = reader["Correo"].ToString();
                TxtTelefono.Text = reader["Telefono"].ToString();
                CbDomicilio.SelectedValue = int.Parse(reader["Id_Domicilio"].ToString());

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

        private void DtpFechaReg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

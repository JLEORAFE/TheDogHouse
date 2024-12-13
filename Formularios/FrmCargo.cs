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
    public partial class FrmCargo : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmCargo()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Cargo").ToString();
        }

        void limpiar()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtDesc.Clear();
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Cargo").ToString();

        }

        bool encontrar()
        {
            bool b = false;
            int Id = int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Cargo WHERE Id = {Id}";
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
            Cargo c = new Cargo();
            c.Id = int.Parse(TxtId.Text);
            c.Codigo = int.Parse(TxtCodigo.Text);
            c.Nombre = TxtNombre.Text;
            c.Descripcion = TxtDesc.Text;

            if (encontrar() == true)
            {
                MessageBox.Show(c.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(c.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaCargo x = new FrmBusquedaCargo();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgCargo.SelectedRows[0].Cells["Id"].Value.ToString();

                TxtCodigo.Text = x.DgCargo.SelectedRows[0].Cells["Codigo"].Value.ToString();

                TxtNombre.Text = x.DgCargo.SelectedRows[0].Cells["Nombre"].Value.ToString();

                TxtDesc.Text = x.DgCargo.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Cargo c = new Cargo();
            c.Id = int.Parse(TxtId.Text);
            MessageBox.Show(c.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Cargo WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtCodigo.Text = reader["Codigo"].ToString();
                TxtNombre.Text = reader["Nombre"].ToString();
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
    }
}

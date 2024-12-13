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
    public partial class FrmSucursal : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmSucursal()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            cargarcbD();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Sucursal").ToString();

            Herramienta cl = new Herramienta();
            TxtNumSuc.Text = cl.ClaveNumSuc("Num_Sucursal", "Sucursal").ToString();
        }

        void limpiar()
        {
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtHorario.Clear();
            cargarcbD();
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Sucursal").ToString();

            Herramienta cl = new Herramienta();
            TxtNumSuc.Text = cl.ClaveNumSuc("Num_Sucursal", "Sucursal").ToString();
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
            int Id = int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Sucursal WHERE Id = {Id}";
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
            Sucursal s = new Sucursal();
            s.Id = int.Parse(TxtId.Text);
            s.NumSuc = int.Parse(TxtNumSuc.Text);
            s.Nombre = TxtNombre.Text;
            s.telefono = TxtTelefono.Text;
            s.horario = TxtHorario.Text;
            s.IdDomi = int.Parse(CbDomicilio.SelectedValue.ToString());

            if (encontrar() == true)
            {
                MessageBox.Show(s.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(s.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaSucursal x = new FrmBusquedaSucursal();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgSucursal.SelectedRows[0].Cells["Id"].Value.ToString();

                TxtNumSuc.Text = x.DgSucursal.SelectedRows[0].Cells["Num_Sucursal"].Value.ToString();

                TxtNombre.Text = x.DgSucursal.SelectedRows[0].Cells["Nombre"].Value.ToString();

                TxtTelefono.Text = x.DgSucursal.SelectedRows[0].Cells["Telefono"].Value.ToString();

                TxtHorario.Text = x.DgSucursal.SelectedRows[0].Cells["Horario"].Value.ToString();

                CbDomicilio.SelectedValue = int.Parse(x.DgSucursal.SelectedRows[0].Cells["Id_Domicilio"].Value.ToString());
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Sucursal s = new Sucursal();
            s.Id = int.Parse(TxtId.Text);
            MessageBox.Show(s.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Sucursal WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtNumSuc.Text = reader["Num_Sucursal"].ToString();
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtTelefono.Text = reader["Telefono"].ToString();
                TxtHorario.Text = reader["Horario"].ToString();
                CbDomicilio.SelectedValue = int.Parse(reader["Id_Domicilio"].ToString());

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
    }
}

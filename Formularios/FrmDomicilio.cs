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
    public partial class FrmDomicilio : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmDomicilio()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmDomicilio_Load(object sender, EventArgs e)
        {
            llenarcbT();
            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Domicilio").ToString();
        }

        void limpiar()
        {
            TxtCP.Clear();
            TxtCalle.Clear();
            TxtColonia.Clear();
            TxtReferencias.Clear();
            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Domicilio").ToString();
            TxtCP.Focus();
        }

        void llenarcbT()
        {
            CbTipo.Items.Add("SUCURSAL");
            CbTipo.Items.Add("ADOPTANTE");
            CbTipo.Items.Add("EMPLEADO");
        }

        bool encontrar()
        {
            bool b = false;
            int ID = int.Parse(TxtId.Text);
            string cadena = $"SELECT * FROM Domicilio WHERE Id = {ID}";
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
            Domicilio d = new Domicilio();
            d.id = int.Parse(TxtId.Text);
            d.cp = TxtCP.Text;
            d.calle = TxtCalle.Text;
            d.colonia = TxtColonia.Text;
            d.referencias = TxtReferencias.Text;
            d.tipo = CbTipo.Text;

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
            Busquedas.FrmBusquedaDomicilio x = new Busquedas.FrmBusquedaDomicilio();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgDomicilio.SelectedRows[0].Cells["Id"].Value.ToString();
                TxtCP.Text = x.DgDomicilio.SelectedRows[0].Cells["CP"].Value.ToString();
                TxtCalle.Text = x.DgDomicilio.SelectedRows[0].Cells["Calle"].Value.ToString();
                TxtColonia.Text = x.DgDomicilio.SelectedRows[0].Cells["Colonia"].Value.ToString();
                TxtReferencias.Text = x.DgDomicilio.SelectedRows[0].Cells["Referencias"].Value.ToString();
                CbTipo.Text = x.DgDomicilio.SelectedRows[0].Cells["Tipo"].Value.ToString();
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Domicilio d = new Domicilio();
            d.id = int.Parse(TxtId.Text);
            MessageBox.Show(d.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Domicilio WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtCP.Text = reader["CP"].ToString();
                TxtCalle.Text = reader["Calle"].ToString();
                TxtColonia.Text = reader["Colonia"].ToString();
                TxtReferencias.Text = reader["Referencias"].ToString();
                CbTipo.Text = reader["Tipo"].ToString();

            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun Domicilio", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

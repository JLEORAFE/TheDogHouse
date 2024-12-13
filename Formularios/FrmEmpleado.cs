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
    public partial class FrmEmpleado : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmEmpleado()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            cargarcbD();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Empleado").ToString();

            Herramienta cl = new Herramienta();
            TxtNumEmp.Text = cl.ClaveNumEmp("Num_Emp", "Empleado").ToString();
        }

        void limpiar()
        {
            TxtNombre.Clear();
            TxtApellidoP.Clear();
            TxtApellidoM.Clear();
            DtpFechaNac.Value = DateTime.Today;
            TxtEdad.Clear();
            DtpFechaReg.Value = DateTime.Today;
            TxtCorreo.Clear();
            TxtTelefono.Clear();
            TxtContraseña.Clear();
            cargarcbD();
            TxtNombre.Focus();

            Herramienta h = new Herramienta();
            TxtId.Text = h.consecutivo("id", "Empleado").ToString();

            Herramienta cl = new Herramienta();
            TxtNumEmp.Text = cl.ClaveNumEmp("Num_Emp", "Empleado").ToString();
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
            string cadena = $"SELECT * FROM Empleado WHERE Id = {Id}";
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
            Empleado em = new Empleado();
            em.Id = int.Parse(TxtId.Text);
            em.NumEmp = int.Parse(TxtNumEmp.Text);
            em.Nombre = TxtNombre.Text;
            em.ApellidoP = TxtApellidoP.Text;
            em.ApellidoM = TxtApellidoM.Text;
            string FechaNacimiento = DtpFechaNac.Value.Year + "/" + DtpFechaNac.Value.Month + "/" + DtpFechaNac.Value.Day;
            em.FechaN = FechaNacimiento;
            em.edad = int.Parse(TxtEdad.Text);
            string FechaRegistro = DtpFechaReg.Value.Year + "/" + DtpFechaReg.Value.Month + "/" + DtpFechaReg.Value.Day;
            em.Fechareg = FechaRegistro;
            em.correo = TxtCorreo.Text;
            em.telefono = TxtTelefono.Text;
            em.contraseña = TxtContraseña.Text;
            em.IdDomi = int.Parse(CbDomicilio.SelectedValue.ToString());

            if (encontrar() == true)
            {
                MessageBox.Show(em.Actualizar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(em.Guardar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void TsBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaEmpleado x = new FrmBusquedaEmpleado();
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                TxtId.Text = x.DgEmpleado.SelectedRows[0].Cells["Id"].Value.ToString();

                TxtNumEmp.Text = x.DgEmpleado.SelectedRows[0].Cells["Num_Emp"].Value.ToString();
                
                TxtNombre.Text = x.DgEmpleado.SelectedRows[0].Cells["Nombre"].Value.ToString();
                
                TxtApellidoP.Text = x.DgEmpleado.SelectedRows[0].Cells["ApellidoP"].Value.ToString();
                
                TxtApellidoM.Text = x.DgEmpleado.SelectedRows[0].Cells["ApellidoM"].Value.ToString();
                
                DtpFechaNac.Value = DateTime.Parse(x.DgEmpleado.SelectedRows[0].Cells["Fecha_Nac"].Value.ToString());
                
                TxtEdad.Text = x.DgEmpleado.SelectedRows[0].Cells["Edad"].Value.ToString();
                
                DtpFechaReg.Value = DateTime.Parse(x.DgEmpleado.SelectedRows[0].Cells["Fecha_Reg"].Value.ToString());
                
                TxtCorreo.Text = x.DgEmpleado.SelectedRows[0].Cells["Correo"].Value.ToString();
                
                TxtTelefono.Text = x.DgEmpleado.SelectedRows[0].Cells["Telefono"].Value.ToString();

                TxtContraseña.Text = x.DgEmpleado.SelectedRows[0].Cells["Contraseña"].Value.ToString();
                
                CbDomicilio.SelectedValue = int.Parse(x.DgEmpleado.SelectedRows[0].Cells["Id_Domicilio"].Value.ToString());
            }
        }

        private void TsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TsEliminar_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado();
            em.Id = int.Parse(TxtId.Text);
            MessageBox.Show(em.Eliminar(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            limpiar();
        }

        void Obtener()
        {
            string consulta = $"SELECT * FROM Empleado WHERE Id = {TxtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TxtNumEmp.Text = reader["Num_Emp"].ToString();
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtApellidoP.Text = reader["ApellidoP"].ToString();
                TxtApellidoM.Text = reader["ApellidoM"].ToString();
                DtpFechaNac.Value = DateTime.Parse(reader["Fecha_Nac"].ToString());
                TxtEdad.Text = reader["Edad"].ToString();
                DtpFechaReg.Value = DateTime.Parse(reader["Fecha_Reg"].ToString());
                TxtCorreo.Text = reader["Correo"].ToString();
                TxtTelefono.Text = reader["Telefono"].ToString();
                TxtContraseña.Text = reader["Contraseña"].ToString();
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

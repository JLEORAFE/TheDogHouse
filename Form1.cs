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
using TheDogHouse.Formularios;

namespace TheDogHouse
{
    public partial class FrmInisesion : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();


        public FrmInisesion()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        bool Encontro()
        {
            bool b;
            int Num_Empleado = int.Parse(TxtUsuario.Text);
            string Contraseña = TxtContraseña.Text;
            string Consulta = $"select Num_Emp, Contraseña from Empleado where Num_Emp = {Num_Empleado} and Contraseña = '{Contraseña}'";
            con.Open();
            SqlCommand cmd = new SqlCommand(Consulta, con);
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

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        // CAMPO USUARIO
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.White;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.White;
            }
        }

        //CAMPO CONTRASEÑA
        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "CONTRASEÑA")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.White;
                TxtContraseña.PasswordChar = '-';
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.ForeColor = Color.White;
            }
        }

        // BOTON ACCCEDER
        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (Encontro() == true)
            {
                FrmMenu a = new FrmMenu();
                this.Hide();
                a.ShowDialog();
                this.Show();
                TxtUsuario.Clear();
                TxtContraseña.Clear();
            }
            else
            {
                MessageBox.Show("USUARIO Y CONTRASEÑA INCORRECTOS", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //MOSTRAR Y OCULTAR CONTRASEÑA
        private void PbMostrar_Click(object sender, EventArgs e)
        {
            //Imagen Ocultar la mandamos al frente
            PbOcultar.BringToFront();

            //Mostramos la contraseña
            TxtContraseña.PasswordChar = '\0';
        }

        private void PbOcultar_Click(object sender, EventArgs e)
        {
            //Imagen Mostrar la mandamos al frente
            PbMostrar.BringToFront();

            //Ocultamos la contraseña
            TxtContraseña.PasswordChar = '-';
        }

        private void FrmInisesion_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace TheDogHouse.Busquedas
{
    public partial class FrmBusquedaDonacion : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmBusquedaDonacion()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmBusquedaDonacion_Load(object sender, EventArgs e)
        {
            try
            {
                DgDonacion.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        void cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Donacion WHERE Folio LIKE '%{TxtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DgDonacion.DataSource = dt;
            con.Close();

            try
            {
                DgDonacion.Rows[0].Selected = true;
            }
            catch
            {


            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            cargardg();
        }

        private void DgDonacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DgDonacion.CurrentRow.Index;
            DgDonacion.Rows[i].Selected = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

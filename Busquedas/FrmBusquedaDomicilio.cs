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
    public partial class FrmBusquedaDomicilio : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmBusquedaDomicilio()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmBusquedaDomicilio_Load(object sender, EventArgs e)
        {
            try
            {
                DgDomicilio.Rows[0].Selected = true;
            }
            catch
            {

            }
        }
        void cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Domicilio WHERE Tipo LIKE '%{TxtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DgDomicilio.DataSource = dt;
            con.Close();

            try
            {
                DgDomicilio.Rows[0].Selected = true;
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

        private void DgDomicilio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DgDomicilio.CurrentRow.Index;
            DgDomicilio.Rows[i].Selected = true;
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

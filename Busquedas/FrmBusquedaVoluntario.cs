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
    public partial class FrmBusquedaVoluntario : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public FrmBusquedaVoluntario()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void FrmBusquedaVoluntario_Load(object sender, EventArgs e)
        {
            try
            {
                DgVoluntario.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        void cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Voluntario WHERE Num_Volun LIKE '%{TxtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DgVoluntario.DataSource = dt;
            con.Close();

            try
            {
                DgVoluntario.Rows[0].Selected = true;
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

        private void DgVoluntario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DgVoluntario.CurrentRow.Index;
            DgVoluntario.Rows[i].Selected = true;
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

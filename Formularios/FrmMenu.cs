using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDogHouse.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void TsAdoptamte_Click(object sender, EventArgs e)
        {
            FrmAdoptante a = new FrmAdoptante();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsDomicilio_Click(object sender, EventArgs e)
        {
            FrmDomicilio a = new FrmDomicilio();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado a = new FrmEmpleado();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsMascota_Click(object sender, EventArgs e)
        {
            FrmMascota a = new FrmMascota();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsSucursal_Click(object sender, EventArgs e)
        {
            FrmSucursal a = new FrmSucursal();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsDonacion_Click(object sender, EventArgs e)
        {
            FrmDonacion a = new FrmDonacion();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsCargo_Click(object sender, EventArgs e)
        {
            FrmCargo a = new FrmCargo();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TsVoluntario_Click(object sender, EventArgs e)
        {
            FrmVoluntario a = new FrmVoluntario();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}

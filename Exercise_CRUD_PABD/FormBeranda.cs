using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_CRUD_PABD
{
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pbPenyewa_Click(object sender, EventArgs e)
        {
            new FormDataPenyewa().Show();
            this.Hide();
        }

        private void pbBangunan_Click(object sender, EventArgs e)
        {
            new FormDataBangunan().Show();
            this.Hide();
        }

        private void pbTransaksi_Click(object sender, EventArgs e)
        {
            new FormDataTransaksi().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}

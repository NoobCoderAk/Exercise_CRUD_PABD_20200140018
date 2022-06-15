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
    public partial class FormDataTransaksi : Form
    {
        public FormDataTransaksi()
        {
            InitializeComponent();
        }

        private void FormDataTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_MallDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.dB_MallDataSet.Transaksi);

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            new FormDetailTransaksi().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormBeranda().Show();
            this.Hide();
        }
    }
}

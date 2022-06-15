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
    public partial class FormDataPenyewa : Form
    {
        public FormDataPenyewa()
        {
            InitializeComponent();
        }

        private void FormDataPenyewa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_MallDataSet.Penyewa' table. You can move, or remove it, as needed.
            this.penyewaTableAdapter.Fill(this.dB_MallDataSet.Penyewa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormDetailPenyewa().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormBeranda().Show();
            this.Hide();
        }
    }
}

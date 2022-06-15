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
    public partial class FormDataBangunan : Form
    {
        public FormDataBangunan()
        {
            InitializeComponent();
        }

        private void FormDataBangunan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_MallDataSet.Bangunan' table. You can move, or remove it, as needed.
            this.bangunanTableAdapter.Fill(this.dB_MallDataSet.Bangunan);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            new FormDetailBangunan().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormBeranda().Show();
            this.Hide();
        }
    }
}

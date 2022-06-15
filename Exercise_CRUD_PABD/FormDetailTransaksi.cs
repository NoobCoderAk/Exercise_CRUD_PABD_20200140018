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
    public partial class FormDetailTransaksi : Form
    {
        DataTable dt;
        DataRow dr;
        string code;

        public FormDetailTransaksi()
        {
            InitializeComponent();
        }

        private void FormDetailTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_MallDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.dB_MallDataSet.Transaksi);

            txtCode.Enabled = false;
            txtCodeP.Enabled = false;
            txtNameP.Enabled = false;
            txtCodeB.Enabled = false;
            txtNameB.Enabled = false;
            txtTahunan.Enabled = false;
            txtBulanan.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormDataTransaksi().Show();
            this.Hide();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt = dB_MallDataSet.Tables["Transaksi"];
            dr = dt.NewRow();
            dr[0] = txtCode.Text;
            dr[1] = txtCodeP.Text;
            dr[2] = txtNameP.Text;
            dr[3] = txtCodeB.Text;
            dr[4] = txtNameB.Text;
            dr[5] = txtTahunan.Text;
            dr[6] = txtBulanan.Text;
            dt.Rows.Add(dr);
            transaksiTableAdapter.Update(dB_MallDataSet);
            txtCode.Text = System.Convert.ToString(dr[0]);
            txtCode.Enabled = false;
            txtCodeP.Enabled = false;
            txtNameP.Enabled = false;
            txtCodeB.Enabled = false;
            txtNameB.Enabled = false;
            txtTahunan.Enabled = false;
            txtBulanan.Enabled = false;

            this.transaksiTableAdapter.Fill(this.dB_MallDataSet.Transaksi);
            cmdSave.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtCode.Text;
            dr = dB_MallDataSet.Tables["Transaksi"].Rows.Find(code);
            dr.Delete();
            transaksiTableAdapter.Update(dB_MallDataSet);
        }
    }
}

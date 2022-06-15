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

    public partial class FormDetailBangunan : Form
    {

        DataTable dt;
        DataRow dr;
        string code;
        public FormDetailBangunan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDetailBangunan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_MallDataSet.Bangunan' table. You can move, or remove it, as needed.
            this.bangunanTableAdapter.Fill(this.dB_MallDataSet.Bangunan);
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtLokasi.Enabled = false;
            txtTahunan.Enabled = false;
            txtBulanan.Enabled = false;

            cmdSave.Enabled = false;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            txtCode.Enabled = true;
            txtName.Enabled = true;
            txtLokasi.Enabled = true;
            txtTahunan.Enabled = true;
            txtBulanan.Enabled = true;


            txtCode.Text = "";
            txtName.Text = "";
            txtLokasi.Text = "";
            txtTahunan.Text = "";
            txtBulanan.Text = "";

            dt = dB_MallDataSet.Tables["Bangunan"];

            cmdAdd.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt = dB_MallDataSet.Tables["Bangunan"];
            dr = dt.NewRow();
            dr[0] = txtCode.Text;
            dr[1] = txtName.Text;
            dr[2] = txtLokasi.Text;
            dr[3] = txtTahunan.Text;
            dr[4] = txtBulanan.Text;
            dt.Rows.Add(dr);
            bangunanTableAdapter.Update(dB_MallDataSet);
            txtCode.Text = System.Convert.ToString(dr[0]);
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtLokasi.Enabled = false;
            txtTahunan.Enabled = false;
            txtBulanan.Enabled = false;

            this.bangunanTableAdapter.Fill(this.dB_MallDataSet.Bangunan);
            cmdAdd.Enabled = true;
            cmdSave.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtCode.Text;
            dr = dB_MallDataSet.Tables["Bangunan"].Rows.Find(code);
            dr.Delete();
            bangunanTableAdapter.Update(dB_MallDataSet);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormDataBangunan().Show();
            this.Hide();
        }
    }
}

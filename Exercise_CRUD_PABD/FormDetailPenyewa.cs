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
    public partial class FormDetailPenyewa : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public FormDetailPenyewa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormDataPenyewa().Show();
            this.Hide();
        }

        private void FormDetailPenyewa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_MallDataSet.Penyewa' table. You can move, or remove it, as needed.
            this.penyewaTableAdapter.Fill(this.dB_MallDataSet.Penyewa);
            
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtKTP.Enabled = false;
            txtTelp.Enabled = false;
            txtKel.Enabled = false;

            cmdSave.Enabled = false;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtKTP.Enabled = true;
            txtTelp.Enabled = true;
            txtKel.Enabled = true;

            txtName.Text = "";
            txtAddress.Text = "";
            txtKTP.Text = "";
            txtTelp.Text = "";
            txtKel.Text = "";

            int ctr, len;
            string codeval;

            dt = dB_MallDataSet.Tables["Penyewa"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Kode_Penyewa"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                txtCode.Text = "PNY0" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 9))
            {
                ctr = ctr + 1;
                txtCode.Text = "PNY" + ctr;
            }
            else if (ctr >= 90)
            {
                ctr = ctr + 1;
                txtCode.Text = "PNY" + ctr;
            }

            cmdAdd.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt = dB_MallDataSet.Tables["Penyewa"];
            dr = dt.NewRow();
            dr[0] = txtCode.Text;
            dr[1] = txtName.Text;
            dr[2] = txtAddress.Text;
            dr[3] = txtKTP.Text;
            dr[4] = txtTelp.Text;
            dr[5] = txtKel.Text;
            dt.Rows.Add(dr);
            penyewaTableAdapter.Update(dB_MallDataSet);
            txtCode.Text = System.Convert.ToString(dr[0]);
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtKTP.Enabled = false;
            txtTelp.Enabled = false;
            txtKel.Enabled = false;

            this.penyewaTableAdapter.Fill(this.dB_MallDataSet.Penyewa);
            cmdAdd.Enabled = true;
            cmdSave.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtCode.Text;
            dr = dB_MallDataSet.Tables["Penyewa"].Rows.Find(code);
            dr.Delete();
            penyewaTableAdapter.Update(dB_MallDataSet);
        }
    }
}

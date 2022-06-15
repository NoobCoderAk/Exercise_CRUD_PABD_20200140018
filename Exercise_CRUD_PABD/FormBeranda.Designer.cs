
namespace Exercise_CRUD_PABD
{
    partial class FormBeranda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTransaksi = new System.Windows.Forms.PictureBox();
            this.pbBangunan = new System.Windows.Forms.PictureBox();
            this.pbPenyewa = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBangunan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenyewa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(103, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(324, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Bangunan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(562, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Transaksi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_CRUD_PABD.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(752, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbTransaksi
            // 
            this.pbTransaksi.Image = global::Exercise_CRUD_PABD.Properties.Resources.contract;
            this.pbTransaksi.Location = new System.Drawing.Point(587, 161);
            this.pbTransaksi.Name = "pbTransaksi";
            this.pbTransaksi.Size = new System.Drawing.Size(95, 85);
            this.pbTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTransaksi.TabIndex = 2;
            this.pbTransaksi.TabStop = false;
            this.pbTransaksi.Click += new System.EventHandler(this.pbTransaksi_Click);
            // 
            // pbBangunan
            // 
            this.pbBangunan.Image = global::Exercise_CRUD_PABD.Properties.Resources.building;
            this.pbBangunan.Location = new System.Drawing.Point(351, 161);
            this.pbBangunan.Name = "pbBangunan";
            this.pbBangunan.Size = new System.Drawing.Size(95, 85);
            this.pbBangunan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBangunan.TabIndex = 1;
            this.pbBangunan.TabStop = false;
            this.pbBangunan.Click += new System.EventHandler(this.pbBangunan_Click);
            // 
            // pbPenyewa
            // 
            this.pbPenyewa.Image = global::Exercise_CRUD_PABD.Properties.Resources.people;
            this.pbPenyewa.Location = new System.Drawing.Point(123, 161);
            this.pbPenyewa.Name = "pbPenyewa";
            this.pbPenyewa.Size = new System.Drawing.Size(95, 85);
            this.pbPenyewa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPenyewa.TabIndex = 0;
            this.pbPenyewa.TabStop = false;
            this.pbPenyewa.Click += new System.EventHandler(this.pbPenyewa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(343, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormBeranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTransaksi);
            this.Controls.Add(this.pbBangunan);
            this.Controls.Add(this.pbPenyewa);
            this.Name = "FormBeranda";
            this.Text = "Beranda";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBangunan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenyewa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPenyewa;
        private System.Windows.Forms.PictureBox pbBangunan;
        private System.Windows.Forms.PictureBox pbTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}
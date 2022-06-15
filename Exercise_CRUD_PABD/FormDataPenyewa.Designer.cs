
namespace Exercise_CRUD_PABD
{
    partial class FormDataPenyewa
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_MallDataSet = new Exercise_CRUD_PABD.DB_MallDataSet();
            this.penyewaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penyewaTableAdapter = new Exercise_CRUD_PABD.DB_MallDataSetTableAdapters.PenyewaTableAdapter();
            this.kodePenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noKTPPenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpPenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_MallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penyewaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodePenyewaDataGridViewTextBoxColumn,
            this.namaPenyewaDataGridViewTextBoxColumn,
            this.alamatPenyewaDataGridViewTextBoxColumn,
            this.noKTPPenyewaDataGridViewTextBoxColumn,
            this.noTelpPenyewaDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.penyewaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_MallDataSet
            // 
            this.dB_MallDataSet.DataSetName = "DB_MallDataSet";
            this.dB_MallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penyewaBindingSource
            // 
            this.penyewaBindingSource.DataMember = "Penyewa";
            this.penyewaBindingSource.DataSource = this.dB_MallDataSet;
            // 
            // penyewaTableAdapter
            // 
            this.penyewaTableAdapter.ClearBeforeFill = true;
            // 
            // kodePenyewaDataGridViewTextBoxColumn
            // 
            this.kodePenyewaDataGridViewTextBoxColumn.DataPropertyName = "Kode_Penyewa";
            this.kodePenyewaDataGridViewTextBoxColumn.HeaderText = "Kode_Penyewa";
            this.kodePenyewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePenyewaDataGridViewTextBoxColumn.Name = "kodePenyewaDataGridViewTextBoxColumn";
            this.kodePenyewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPenyewaDataGridViewTextBoxColumn
            // 
            this.namaPenyewaDataGridViewTextBoxColumn.DataPropertyName = "Nama_Penyewa";
            this.namaPenyewaDataGridViewTextBoxColumn.HeaderText = "Nama_Penyewa";
            this.namaPenyewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPenyewaDataGridViewTextBoxColumn.Name = "namaPenyewaDataGridViewTextBoxColumn";
            this.namaPenyewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatPenyewaDataGridViewTextBoxColumn
            // 
            this.alamatPenyewaDataGridViewTextBoxColumn.DataPropertyName = "Alamat_Penyewa";
            this.alamatPenyewaDataGridViewTextBoxColumn.HeaderText = "Alamat_Penyewa";
            this.alamatPenyewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatPenyewaDataGridViewTextBoxColumn.Name = "alamatPenyewaDataGridViewTextBoxColumn";
            this.alamatPenyewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // noKTPPenyewaDataGridViewTextBoxColumn
            // 
            this.noKTPPenyewaDataGridViewTextBoxColumn.DataPropertyName = "No_KTP_Penyewa";
            this.noKTPPenyewaDataGridViewTextBoxColumn.HeaderText = "No_KTP_Penyewa";
            this.noKTPPenyewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noKTPPenyewaDataGridViewTextBoxColumn.Name = "noKTPPenyewaDataGridViewTextBoxColumn";
            this.noKTPPenyewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelpPenyewaDataGridViewTextBoxColumn
            // 
            this.noTelpPenyewaDataGridViewTextBoxColumn.DataPropertyName = "No_Telp_Penyewa";
            this.noTelpPenyewaDataGridViewTextBoxColumn.HeaderText = "No_Telp_Penyewa";
            this.noTelpPenyewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelpPenyewaDataGridViewTextBoxColumn.Name = "noTelpPenyewaDataGridViewTextBoxColumn";
            this.noTelpPenyewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(354, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Penyewa";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.LightGray;
            this.btnDetail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(404, 391);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(96, 35);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_CRUD_PABD.Properties.Resources.back___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDataPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataPenyewa";
            this.Text = "FormDataPenyewa";
            this.Load += new System.EventHandler(this.FormDataPenyewa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_MallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penyewaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_MallDataSet dB_MallDataSet;
        private System.Windows.Forms.BindingSource penyewaBindingSource;
        private DB_MallDataSetTableAdapters.PenyewaTableAdapter penyewaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noKTPPenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpPenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace Exercise_CRUD_PABD
{
    partial class FormDataBangunan
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
            this.btnDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_MallDataSet = new Exercise_CRUD_PABD.DB_MallDataSet();
            this.bangunanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangunanTableAdapter = new Exercise_CRUD_PABD.DB_MallDataSetTableAdapters.BangunanTableAdapter();
            this.kodeBangunanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBangunanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiBangunanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_MallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangunanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.LightGray;
            this.btnDetail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(399, 371);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(96, 35);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Bangunan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBangunanDataGridViewTextBoxColumn,
            this.namaBangunanDataGridViewTextBoxColumn,
            this.lokasiBangunanDataGridViewTextBoxColumn,
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn,
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bangunanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 240);
            this.dataGridView1.TabIndex = 4;
            // 
            // dB_MallDataSet
            // 
            this.dB_MallDataSet.DataSetName = "DB_MallDataSet";
            this.dB_MallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangunanBindingSource
            // 
            this.bangunanBindingSource.DataMember = "Bangunan";
            this.bangunanBindingSource.DataSource = this.dB_MallDataSet;
            // 
            // bangunanTableAdapter
            // 
            this.bangunanTableAdapter.ClearBeforeFill = true;
            // 
            // kodeBangunanDataGridViewTextBoxColumn
            // 
            this.kodeBangunanDataGridViewTextBoxColumn.DataPropertyName = "Kode_Bangunan";
            this.kodeBangunanDataGridViewTextBoxColumn.HeaderText = "Kode_Bangunan";
            this.kodeBangunanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeBangunanDataGridViewTextBoxColumn.Name = "kodeBangunanDataGridViewTextBoxColumn";
            this.kodeBangunanDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaBangunanDataGridViewTextBoxColumn
            // 
            this.namaBangunanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Bangunan";
            this.namaBangunanDataGridViewTextBoxColumn.HeaderText = "Nama_Bangunan";
            this.namaBangunanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBangunanDataGridViewTextBoxColumn.Name = "namaBangunanDataGridViewTextBoxColumn";
            this.namaBangunanDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokasiBangunanDataGridViewTextBoxColumn
            // 
            this.lokasiBangunanDataGridViewTextBoxColumn.DataPropertyName = "Lokasi_Bangunan";
            this.lokasiBangunanDataGridViewTextBoxColumn.HeaderText = "Lokasi_Bangunan";
            this.lokasiBangunanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiBangunanDataGridViewTextBoxColumn.Name = "lokasiBangunanDataGridViewTextBoxColumn";
            this.lokasiBangunanDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaBangunanPerTahunDataGridViewTextBoxColumn
            // 
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn.DataPropertyName = "Harga_Bangunan_Per_Tahun";
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn.HeaderText = "Harga_Bangunan_Per_Tahun";
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn.Name = "hargaBangunanPerTahunDataGridViewTextBoxColumn";
            this.hargaBangunanPerTahunDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaBangunanPerBulanDataGridViewTextBoxColumn
            // 
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn.DataPropertyName = "Harga_Bangunan_Per_Bulan";
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn.HeaderText = "Harga_Bangunan_Per_Bulan";
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn.Name = "hargaBangunanPerBulanDataGridViewTextBoxColumn";
            this.hargaBangunanPerBulanDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_CRUD_PABD.Properties.Resources.back___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(7, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDataBangunan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataBangunan";
            this.Text = "FormDataBangunan";
            this.Load += new System.EventHandler(this.FormDataBangunan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_MallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangunanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_MallDataSet dB_MallDataSet;
        private System.Windows.Forms.BindingSource bangunanBindingSource;
        private DB_MallDataSetTableAdapters.BangunanTableAdapter bangunanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBangunanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBangunanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiBangunanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBangunanPerTahunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBangunanPerBulanDataGridViewTextBoxColumn;
    }
}
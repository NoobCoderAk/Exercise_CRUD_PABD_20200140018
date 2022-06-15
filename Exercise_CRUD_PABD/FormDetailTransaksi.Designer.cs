
namespace Exercise_CRUD_PABD
{
    partial class FormDetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailTransaksi));
            this.label7 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.txtCodeB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodeP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.txtTahunan = new System.Windows.Forms.TextBox();
            this.txtBulanan = new System.Windows.Forms.TextBox();
            this.dB_MallDataSet = new Exercise_CRUD_PABD.DB_MallDataSet();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new Exercise_CRUD_PABD.DB_MallDataSetTableAdapters.TransaksiTableAdapter();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_MallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(176, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 48);
            this.label7.TabIndex = 16;
            this.label7.Text = "Detail Transaksi";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.transaksiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(697, 27);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_CRUD_PABD.Properties.Resources.back___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(6, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.68224F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.31776F));
            this.tableLayoutPanel1.Controls.Add(this.txtBulanan, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtTahunan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNameB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCodeB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCodeP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNameP, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 233);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Harga/Bulan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Transaksi";
            // 
            // txtNameB
            // 
            this.txtNameB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Nama_Bangunan", true));
            this.txtNameB.Location = new System.Drawing.Point(148, 133);
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.Size = new System.Drawing.Size(230, 22);
            this.txtNameB.TabIndex = 12;
            // 
            // txtCodeB
            // 
            this.txtCodeB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Kode_Bangunan", true));
            this.txtCodeB.Location = new System.Drawing.Point(148, 101);
            this.txtCodeB.Name = "txtCodeB";
            this.txtCodeB.Size = new System.Drawing.Size(230, 22);
            this.txtCodeB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kode Bangunan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nama Bangunan";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Kode_Transaksi", true));
            this.txtCode.Location = new System.Drawing.Point(148, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(230, 22);
            this.txtCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Harga/Tahun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Penyewa";
            // 
            // txtCodeP
            // 
            this.txtCodeP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Kode_Penyewa", true));
            this.txtCodeP.Location = new System.Drawing.Point(148, 37);
            this.txtCodeP.Name = "txtCodeP";
            this.txtCodeP.Size = new System.Drawing.Size(230, 22);
            this.txtCodeP.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nama Penyewa";
            // 
            // txtNameP
            // 
            this.txtNameP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Nama_Penyewa", true));
            this.txtNameP.Location = new System.Drawing.Point(148, 70);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(230, 22);
            this.txtNameP.TabIndex = 14;
            // 
            // txtTahunan
            // 
            this.txtTahunan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Harga_Bangunan_Per_Tahun", true));
            this.txtTahunan.Location = new System.Drawing.Point(148, 168);
            this.txtTahunan.Name = "txtTahunan";
            this.txtTahunan.Size = new System.Drawing.Size(230, 22);
            this.txtTahunan.TabIndex = 19;
            // 
            // txtBulanan
            // 
            this.txtBulanan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Harga_Bangunan_Per_Bulan", true));
            this.txtBulanan.Location = new System.Drawing.Point(148, 202);
            this.txtBulanan.Name = "txtBulanan";
            this.txtBulanan.Size = new System.Drawing.Size(230, 22);
            this.txtBulanan.TabIndex = 20;
            // 
            // dB_MallDataSet
            // 
            this.dB_MallDataSet.DataSetName = "DB_MallDataSet";
            this.dB_MallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.dB_MallDataSet;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.LightGray;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Location = new System.Drawing.Point(560, 236);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(100, 40);
            this.cmdDelete.TabIndex = 20;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.LightGray;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Location = new System.Drawing.Point(560, 163);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 40);
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // FormDetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDetailTransaksi";
            this.Text = "FormDetailTransaksi";
            this.Load += new System.EventHandler(this.FormDetailTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_MallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBulanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahunan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameB;
        private System.Windows.Forms.TextBox txtCodeB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameP;
        private DB_MallDataSet dB_MallDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private DB_MallDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
    }
}
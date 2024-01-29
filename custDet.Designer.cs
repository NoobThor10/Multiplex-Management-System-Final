namespace MultiplexManagementSystem
{
    partial class custDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(custDet));
            this.custBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDBDataSet = new MultiplexManagementSystem.customerDBDataSet();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SearchTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custTableAdapter = new MultiplexManagementSystem.customerDBDataSetTableAdapters.custTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custAndMovieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custAndMovieDBDataSet = new MultiplexManagementSystem.CustAndMovieDBDataSet();
            this.mCDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieCustDBDataSet = new MultiplexManagementSystem.movieCustDBDataSet();
            this.mCDBTableAdapter = new MultiplexManagementSystem.movieCustDBDataSetTableAdapters.MCDBTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cMDBTableAdapter = new MultiplexManagementSystem.CustAndMovieDBDataSetTableAdapters.CMDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.custBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndMovieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndMovieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCustDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // custBindingSource
            // 
            this.custBindingSource.DataMember = "cust";
            this.custBindingSource.DataSource = this.customerDBDataSet;
            // 
            // customerDBDataSet
            // 
            this.customerDBDataSet.DataSetName = "customerDBDataSet";
            this.customerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(792, 112);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(81, 29);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchTxtbox
            // 
            this.SearchTxtbox.Location = new System.Drawing.Point(200, 118);
            this.SearchTxtbox.Name = "SearchTxtbox";
            this.SearchTxtbox.Size = new System.Drawing.Size(576, 20);
            this.SearchTxtbox.TabIndex = 4;
            this.SearchTxtbox.TextChanged += new System.EventHandler(this.SearchTxtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // custTableAdapter
            // 
            this.custTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.movieNameDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cMDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(127, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 379);
            this.dataGridView1.TabIndex = 16;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "custName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "custName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 120F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "movieName";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "movieName";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            this.movieNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMDBBindingSource
            // 
            this.cMDBBindingSource.DataMember = "CMDB";
            this.cMDBBindingSource.DataSource = this.custAndMovieDBDataSetBindingSource;
            // 
            // custAndMovieDBDataSetBindingSource
            // 
            this.custAndMovieDBDataSetBindingSource.DataSource = this.custAndMovieDBDataSet;
            this.custAndMovieDBDataSetBindingSource.Position = 0;
            // 
            // custAndMovieDBDataSet
            // 
            this.custAndMovieDBDataSet.DataSetName = "CustAndMovieDBDataSet";
            this.custAndMovieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCDBBindingSource
            // 
            this.mCDBBindingSource.DataMember = "MCDB";
            this.mCDBBindingSource.DataSource = this.movieCustDBDataSet;
            // 
            // movieCustDBDataSet
            // 
            this.movieCustDBDataSet.DataSetName = "movieCustDBDataSet";
            this.movieCustDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCDBTableAdapter
            // 
            this.mCDBTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Details";
            // 
            // cMDBTableAdapter
            // 
            this.cMDBTableAdapter.ClearBeforeFill = true;
            // 
            // custDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.SearchTxtbox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "custDet";
            this.Text = "addcustomer";
            this.Load += new System.EventHandler(this.addcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndMovieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAndMovieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCustDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox SearchTxtbox;
        private System.Windows.Forms.Label label6;
        private customerDBDataSet customerDBDataSet;
        private System.Windows.Forms.BindingSource custBindingSource;
        private customerDBDataSetTableAdapters.custTableAdapter custTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private movieCustDBDataSet movieCustDBDataSet;
        private System.Windows.Forms.BindingSource mCDBBindingSource;
        private movieCustDBDataSetTableAdapters.MCDBTableAdapter mCDBTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource custAndMovieDBDataSetBindingSource;
        private CustAndMovieDBDataSet custAndMovieDBDataSet;
        private System.Windows.Forms.BindingSource cMDBBindingSource;
        private CustAndMovieDBDataSetTableAdapters.CMDBTableAdapter cMDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
    }
}
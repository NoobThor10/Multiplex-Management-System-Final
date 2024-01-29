namespace MultiplexManagementSystem
{
    partial class printBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printBill));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseCustandMovieDataSet = new MultiplexManagementSystem.DatabaseCustandMovieDataSet();
            this.mCDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCDBTableAdapter = new MultiplexManagementSystem.DatabaseCustandMovieDataSetTableAdapters.MCDBTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custNTxtbox = new System.Windows.Forms.TextBox();
            this.MovieNTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.printbtn = new System.Windows.Forms.Button();
            this.printPreview = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCustandMovieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDBBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Print Bill";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.movieNameDataGridViewTextBoxColumn,
            this.showTimeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mCDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 279);
            this.dataGridView1.TabIndex = 24;
            // 
            // databaseCustandMovieDataSet
            // 
            this.databaseCustandMovieDataSet.DataSetName = "DatabaseCustandMovieDataSet";
            this.databaseCustandMovieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCDBBindingSource
            // 
            this.mCDBBindingSource.DataMember = "MCDB";
            this.mCDBBindingSource.DataSource = this.databaseCustandMovieDataSet;
            // 
            // mCDBTableAdapter
            // 
            this.mCDBTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "custName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "custName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "movieName";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "movieName";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            // 
            // showTimeDataGridViewTextBoxColumn
            // 
            this.showTimeDataGridViewTextBoxColumn.DataPropertyName = "showTime";
            this.showTimeDataGridViewTextBoxColumn.HeaderText = "showTime";
            this.showTimeDataGridViewTextBoxColumn.Name = "showTimeDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Payment Type";
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mCDBBindingSource, "total", true));
            this.totalTxtBox.Location = new System.Drawing.Point(722, 208);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(208, 20);
            this.totalTxtBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(620, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total";
            // 
            // ShowTxtbox
            // 
            this.ShowTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mCDBBindingSource, "showTime", true));
            this.ShowTxtbox.Location = new System.Drawing.Point(722, 96);
            this.ShowTxtbox.Name = "ShowTxtbox";
            this.ShowTxtbox.Size = new System.Drawing.Size(207, 20);
            this.ShowTxtbox.TabIndex = 28;
            this.ShowTxtbox.TextChanged += new System.EventHandler(this.ShowTxtbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Show Time";
            // 
            // custNTxtbox
            // 
            this.custNTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mCDBBindingSource, "custName", true));
            this.custNTxtbox.Location = new System.Drawing.Point(199, 153);
            this.custNTxtbox.Name = "custNTxtbox";
            this.custNTxtbox.Size = new System.Drawing.Size(277, 20);
            this.custNTxtbox.TabIndex = 25;
            // 
            // MovieNTxtbox
            // 
            this.MovieNTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mCDBBindingSource, "movieName", true));
            this.MovieNTxtbox.Location = new System.Drawing.Point(199, 207);
            this.MovieNTxtbox.Name = "MovieNTxtbox";
            this.MovieNTxtbox.Size = new System.Drawing.Size(277, 20);
            this.MovieNTxtbox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer Name";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mCDBBindingSource, "paymentType", true));
            this.paymentTextBox.Location = new System.Drawing.Point(722, 153);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(208, 20);
            this.paymentTextBox.TabIndex = 35;
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(825, 558);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(104, 30);
            this.printbtn.TabIndex = 36;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // printPreview
            // 
            this.printPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPreview.Location = new System.Drawing.Point(699, 558);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(104, 30);
            this.printPreview.TabIndex = 37;
            this.printPreview.Text = "Print Preview";
            this.printPreview.UseVisualStyleBackColor = true;
            this.printPreview.Click += new System.EventHandler(this.printPreview_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // IDtextBox
            // 
            this.IDtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mCDBBindingSource, "ID", true));
            this.IDtextBox.Location = new System.Drawing.Point(199, 96);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(277, 20);
            this.IDtextBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Bill ID";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(471, 558);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 31);
            this.addBtn.TabIndex = 41;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(585, 558);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(91, 31);
            this.savebtn.TabIndex = 40;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // printBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.printPreview);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShowTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.custNTxtbox);
            this.Controls.Add(this.MovieNTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "printBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printBill";
            this.Load += new System.EventHandler(this.printBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCustandMovieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseCustandMovieDataSet databaseCustandMovieDataSet;
        private System.Windows.Forms.BindingSource mCDBBindingSource;
        private DatabaseCustandMovieDataSetTableAdapters.MCDBTableAdapter mCDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShowTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custNTxtbox;
        private System.Windows.Forms.TextBox MovieNTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button printPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button savebtn;
    }
}
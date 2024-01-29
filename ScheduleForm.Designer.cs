namespace MultiplexManagementSystem
{
    partial class schedule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addbookingbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timmingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.movieDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addmovieDataSet = new MultiplexManagementSystem.addmovieDataSet();
            this.movieDetTableAdapter = new MultiplexManagementSystem.addmovieDataSetTableAdapters.movieDetTableAdapter();
            this.mCDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieCustDBDataSet = new MultiplexManagementSystem.movieCustDBDataSet();
            this.mCDBTableAdapter = new MultiplexManagementSystem.movieCustDBDataSetTableAdapters.MCDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmovieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCustDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // addbookingbtn
            // 
            this.addbookingbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbookingbtn.Location = new System.Drawing.Point(54, 37);
            this.addbookingbtn.Name = "addbookingbtn";
            this.addbookingbtn.Size = new System.Drawing.Size(115, 36);
            this.addbookingbtn.TabIndex = 2;
            this.addbookingbtn.Text = "Change Schedule";
            this.addbookingbtn.UseVisualStyleBackColor = true;
            this.addbookingbtn.Click += new System.EventHandler(this.addbookingbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.timmingDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.movieDetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 430);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // timmingDataGridViewTextBoxColumn
            // 
            this.timmingDataGridViewTextBoxColumn.DataPropertyName = "timming";
            this.timmingDataGridViewTextBoxColumn.HeaderText = "timming";
            this.timmingDataGridViewTextBoxColumn.Name = "timmingDataGridViewTextBoxColumn";
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "img";
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            // 
            // movieDetBindingSource
            // 
            this.movieDetBindingSource.DataMember = "movieDet";
            this.movieDetBindingSource.DataSource = this.addmovieDataSet;
            // 
            // addmovieDataSet
            // 
            this.addmovieDataSet.DataSetName = "addmovieDataSet";
            this.addmovieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieDetTableAdapter
            // 
            this.movieDetTableAdapter.ClearBeforeFill = true;
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
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addbookingbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "schedule";
            this.Load += new System.EventHandler(this.booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmovieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCustDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private movieCustDBDataSet movieCustDBDataSet;
        private System.Windows.Forms.BindingSource mCDBBindingSource;
        private movieCustDBDataSetTableAdapters.MCDBTableAdapter mCDBTableAdapter;
        private System.Windows.Forms.Button addbookingbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private addmovieDataSet addmovieDataSet;
        private System.Windows.Forms.BindingSource movieDetBindingSource;
        private addmovieDataSetTableAdapters.movieDetTableAdapter movieDetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timmingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
    }
}
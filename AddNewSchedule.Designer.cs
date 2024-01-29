namespace MultiplexManagementSystem
{
    partial class AddNewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSchedule));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.movieDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addmovieDataSet = new MultiplexManagementSystem.addmovieDataSet();
            this.timmingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timmingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.MoviecomboBox = new System.Windows.Forms.ComboBox();
            this.MovieLbl = new System.Windows.Forms.Label();
            this.movieDetTableAdapter = new MultiplexManagementSystem.addmovieDataSetTableAdapters.movieDetTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmovieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Browsebtn
            // 
            this.Browsebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebtn.Location = new System.Drawing.Point(658, 236);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(104, 30);
            this.Browsebtn.TabIndex = 62;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.movieDetBindingSource, "img", true));
            this.pictureBox1.Location = new System.Drawing.Point(633, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
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
            // timmingTextBox
            // 
            this.timmingTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.timmingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieDetBindingSource, "timming", true));
            this.timmingTextBox.Location = new System.Drawing.Point(120, 176);
            this.timmingTextBox.Name = "timmingTextBox";
            this.timmingTextBox.Size = new System.Drawing.Size(277, 20);
            this.timmingTextBox.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "timming";
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieDetBindingSource, "genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(120, 119);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(277, 20);
            this.genreTextBox.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Genre";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(688, 497);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 31);
            this.addBtn.TabIndex = 55;
            this.addBtn.Text = "New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(802, 497);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(91, 31);
            this.savebtn.TabIndex = 54;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(101, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 108);
            this.dataGridView1.TabIndex = 56;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Movie Details : ";
            // 
            // MoviecomboBox
            // 
            this.MoviecomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.MoviecomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.movieDetBindingSource, "name", true));
            this.MoviecomboBox.FormattingEnabled = true;
            this.MoviecomboBox.Items.AddRange(new object[] {
            "The Martian",
            "Intersteller",
            "Openhimer",
            "Barbie",
            "Fight Club"});
            this.MoviecomboBox.Location = new System.Drawing.Point(120, 61);
            this.MoviecomboBox.Name = "MoviecomboBox";
            this.MoviecomboBox.Size = new System.Drawing.Size(277, 21);
            this.MoviecomboBox.TabIndex = 51;
            // 
            // MovieLbl
            // 
            this.MovieLbl.AutoSize = true;
            this.MovieLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLbl.Location = new System.Drawing.Point(25, 63);
            this.MovieLbl.Name = "MovieLbl";
            this.MovieLbl.Size = new System.Drawing.Size(73, 15);
            this.MovieLbl.TabIndex = 52;
            this.MovieLbl.Text = "Movie name";
            // 
            // movieDetTableAdapter
            // 
            this.movieDetTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MovieLbl);
            this.panel1.Controls.Add(this.Browsebtn);
            this.panel1.Controls.Add(this.MoviecomboBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timmingTextBox);
            this.panel1.Controls.Add(this.genreTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(101, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 269);
            this.panel1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Add img : ";
            // 
            // AddNewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewBookings";
            this.Load += new System.EventHandler(this.AddNewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmovieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox timmingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MoviecomboBox;
        private System.Windows.Forms.Label MovieLbl;
        private addmovieDataSet addmovieDataSet;
        private System.Windows.Forms.BindingSource movieDetBindingSource;
        private addmovieDataSetTableAdapters.movieDetTableAdapter movieDetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timmingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
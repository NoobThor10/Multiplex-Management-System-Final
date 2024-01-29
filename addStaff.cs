using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplexManagementSystem
{
    public partial class addStaff : Form
    {
        public addStaff()
        {
            InitializeComponent();
        }

        private void addStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.StaffTB' table. You can move, or remove it, as needed.
            this.staffTBTableAdapter.Fill(this.databaseCustandMovieDataSet.StaffTB);
            staffTBBindingSource.DataSource = this.databaseCustandMovieDataSet.StaffTB;
            // TODO: This line of code loads data into the 'empDBDataSet1.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter1.Fill(this.empDBDataSet1.Employees);
            //employeesBindingSource3.DataSource = this.empDBDataSet1.Employees;
            // TODO: This line of code loads data into the 'database2DataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.database2DataSet.Employees);
            //employeesBindingSource.DataSource = this.database2DataSet.Employees;
            // TODO: This line of code loads data into the 'database1DataSet2.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.database1DataSet2.Employee);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //
        private void Newbtn_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                FirstNTxtbox.Focus();
                this.databaseCustandMovieDataSet.StaffTB.AddStaffTBRow(this.databaseCustandMovieDataSet.StaffTB.NewStaffTBRow());
                staffTBBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffTBBindingSource.ResetBindings(false);
                //throw;
            }
        }
        //
        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                staffTBBindingSource.EndEdit();
                staffTBTableAdapter.Update(this.databaseCustandMovieDataSet.StaffTB);
                panel1.Enabled = false;
                dataGridView1.Visible = false;
                label4.Visible = false;
                searchBtn.Visible = false;
                SearchTxtbox.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffTBBindingSource.ResetBindings(false);
                //throw;
            }
        }
        //
        private void editbtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            label4.Visible = true;
            searchBtn.Visible = true;
            SearchTxtbox.Visible = true;
            dataGridView1.Visible = true;
            FirstNTxtbox.Focus();
        }
        //
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            label4.Visible = false;
            searchBtn.Visible = false;
            SearchTxtbox.Visible = false;
            staffTBBindingSource.ResetBindings(false);
        }
        //
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void SearchTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(SearchTxtbox.Text))
                {
                    dataGridView1.DataSource = staffTBBindingSource;
                }
                else
                {
                    var query = from o in this.databaseCustandMovieDataSet.StaffTB
                                where o.firstName.Contains(SearchTxtbox.Text) || o.lastName.Contains(SearchTxtbox.Text) || o.email == SearchTxtbox.Text || o.address == SearchTxtbox.Text || o.salary == SearchTxtbox.Text || o.roles.Contains(SearchTxtbox.Text) || o.ID.Equals(SearchTxtbox.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                    dataGridView1.Visible = true;
                }
            }
        }

        private void SearchTxtbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
           // if (e. == (char)13)
           // {
                if (string.IsNullOrEmpty(SearchTxtbox.Text))
                {
                    dataGridView1.DataSource = staffTBBindingSource;
                }
                else
                {
                    var query = from o in this.databaseCustandMovieDataSet.StaffTB
                                where o.firstName.Contains(SearchTxtbox.Text) || o.lastName.Contains(SearchTxtbox.Text) || o.email == SearchTxtbox.Text || o.address == SearchTxtbox.Text || o.salary == SearchTxtbox.Text || o.roles.Contains(SearchTxtbox.Text) || o.ID.Equals(SearchTxtbox.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                    dataGridView1.Visible = true;
                }
           // }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewStaff staff = new viewStaff();
            staff.ShowDialog();
        }

        private void SearchTxtbox_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}

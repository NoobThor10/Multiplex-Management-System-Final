using MultiplexManagementSystem.DatabaseCustandMovieDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplexManagementSystem
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supplierDataSet.supplier);
            

    }
        private void editbtn_Click(object sender, EventArgs e)
        {
            //SearchTxtbox.Visible = true;
            dataGridView1.Visible = true;
            FirstNTxtbox.Focus();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            try
            {
               // panel1.Enabled = true;
                FirstNTxtbox.Focus();
                this.supplierDataSet.supplier.AddsupplierRow(this.supplierDataSet.supplier.NewsupplierRow());
                supplierBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                supplierBindingSource.ResetBindings(false);
                //throw;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                supplierBindingSource.EndEdit();
                supplierTableAdapter.Update(this.supplierDataSet.supplier);
                //panel1.Enabled = false;
                //dataGridView1.Visible = false;
                //label4.Visible = false;
               // searchBtn.Visible = false;
                //SearchTxtbox.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                supplierBindingSource.ResetBindings(false);
                //throw;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //DashboardForm dashboard = new DashboardForm();
            //dashboard.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

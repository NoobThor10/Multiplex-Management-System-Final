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
    public partial class custDet : Form
    {
        public custDet()
        {
            InitializeComponent();
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'custAndMovieDBDataSet.CMDB' table. You can move, or remove it, as needed.
            this.cMDBTableAdapter.Fill(this.custAndMovieDBDataSet.CMDB);
            // TODO: This line of code loads data into the 'movieCustDBDataSet.MCDB' table. You can move, or remove it, as needed.
            //this.mCDBTableAdapter.Fill(this.movieCustDBDataSet.MCDB);
            // TODO: This line of code loads data into the 'customerDBDataSet.cust' table. You can move, or remove it, as needed.
            //this.custTableAdapter.Fill(this.customerDBDataSet.cust);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTxtbox.Text))
            {
                dataGridView1.DataSource = cMDBBindingSource;
            }
            else
            {
                var query = from o in this.custAndMovieDBDataSet.CMDB
                            where o.custName.Contains(SearchTxtbox.Text) || o.email == SearchTxtbox.Text || o.movieName == SearchTxtbox.Text || o.total == SearchTxtbox.Text || o.paymentType == SearchTxtbox.Text || o.ID.Equals(SearchTxtbox.Text)
                            select o;
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Visible = true;
            }
        }

        private void SearchTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}

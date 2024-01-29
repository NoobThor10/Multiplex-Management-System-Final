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
    public partial class ViewMovieDet : Form
    {
        public ViewMovieDet()
        {
            InitializeComponent();
        }

        private void ViewMovieDet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.MCDB' table. You can move, or remove it, as needed.
            this.mCDBTableAdapter.Fill(this.databaseCustandMovieDataSet.MCDB);
            mCDBBindingSource.DataSource = this.databaseCustandMovieDataSet.MCDB;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(SearchTxtbox.Text))
            {
                dataGridView1.DataSource = mCDBBindingSource;
            }
            else
            {
                var query = from o in this.databaseCustandMovieDataSet.MCDB
                            where o.movieName.Contains(SearchTxtbox.Text) || o.custName.Contains(SearchTxtbox.Text) || o.email == SearchTxtbox.Text || o.contact == SearchTxtbox.Text || o.showTime == SearchTxtbox.Text || o.screen.Contains(SearchTxtbox.Text) || o.total == SearchTxtbox.Text|| o.paymentType == SearchTxtbox.Text || o.ID.Equals(SearchTxtbox.Text)
                            select o;
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}

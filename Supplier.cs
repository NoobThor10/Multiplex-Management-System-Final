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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //DashboardForm dashboard = new DashboardForm();
            //dashboard.Show();
            this.Hide();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supplierDataSet.supplier);


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(SearchTxtbox.Text))
            {
                dataGridView1.DataSource = supplierBindingSource;
            }
            else
            {
                var query = from o in this.supplierDataSet.supplier
                            where o.name.Contains(SearchTxtbox.Text) || o.dept.Contains(SearchTxtbox.Text) || o.purchased == SearchTxtbox.Text ||o.email == SearchTxtbox.Text || o.contact == SearchTxtbox.Text || o.Address.Contains(SearchTxtbox.Text) || o.ID.Equals(SearchTxtbox.Text)
                            select o;
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Visible = true;
            }
        }
    }
}

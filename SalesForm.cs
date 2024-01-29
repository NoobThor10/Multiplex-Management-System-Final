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
    public partial class SalesForm : Form
    {
        
        public SalesForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supplierDataSet.supplier);
            // TODO: This line of code loads data into the 'foodDataSet.fdSale' table. You can move, or remove it, as needed.
            this.fdSaleTableAdapter.Fill(this.foodDataSet.fdSale);
            // TODO: This line of code loads data into the 'saleDBDataSet.movieSale' table. You can move, or remove it, as needed.
            this.movieSaleTableAdapter.Fill(this.saleDBDataSet.movieSale);
            this.ControlBox = false;
            chart1.Series[0].XValueMember = "months";
            chart1.Series[0].YValueMembers = "sale";

            chart1.DataSource = saleDBDataSet.movieSale;
            chart1.DataBind();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            dataGridView3.Visible = false;
            label3.Visible = false;
            Viewbtn.Visible = false;
            dataGridView1.BringToFront();
            chart1.BringToFront();
            TconverLbl.BringToFront();
        }
        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            //linkLabel1.Font = new Font("Segoe UI", 10, Semibold);

        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            dataGridView2.BringToFront();
            Viewbtn.Visible = true;
            dataGridView3.Visible = true;
            label3.Visible = true;
            chart2.BringToFront();
            FconverLbl.BringToFront();
            chart2.Series[0].XValueMember = "months";
            chart2.Series[0].YValueMembers = "sale";

            chart2.DataSource = foodDataSet.fdSale;
            chart2.DataBind();
        }



        //Not in use Btn
        private void FconverLbl_Click(object sender, EventArgs e)
        {

        }

        private void TconverLbl_Click(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class printBill : Form
    {
        public printBill()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Bill bill = new Bill();
            //bill.Show();
            this.Close();
        }

        private void printBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.MCDB' table. You can move, or remove it, as needed.
            this.mCDBTableAdapter.Fill(this.databaseCustandMovieDataSet.MCDB);
            mCDBBindingSource.DataSource = this.databaseCustandMovieDataSet.MCDB;
        }

        private void printPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string dashline = "-------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("--------------------------------------------------------------CINEMAX THEATRE----------------------------------------------------------------------", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 170));
            e.Graphics.DrawString("Ticket id :" + IDtextBox.Text, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Date :" + DateTime.Now, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Customer Name", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Movie Name", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("Mode of Payment", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(650, 250));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString(custNTxtbox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 325));
            e.Graphics.DrawString(MovieNTxtbox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, 325));
            e.Graphics.DrawString(paymentTextBox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(650, 325));

            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 500));
            e.Graphics.DrawString("Total :", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 525));
            e.Graphics.DrawString(totalTxtBox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 525));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 550));
        }

        private void ShowTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //
                
                
                    mCDBBindingSource.EndEdit();
                    mCDBTableAdapter.Update(this.databaseCustandMovieDataSet.MCDB);
                   // panel1.Enabled = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mCDBBindingSource.ResetBindings(false);
                //throw;

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
               // panel1.Enabled = true;
                IDtextBox.Focus();
                this.databaseCustandMovieDataSet.MCDB.AddMCDBRow(this.databaseCustandMovieDataSet.MCDB.NewMCDBRow());
                mCDBBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mCDBBindingSource.ResetBindings(false);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplexManagementSystem
{
    public partial class Ticket : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Darshan\source\repos\MultiplexManagementSystemSln\MultiplexManagementSystem\DatabaseCustandMovie.accdb");
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.MCDB' table. You can move, or remove it, as needed.
            this.mCDBTableAdapter.Fill(this.databaseCustandMovieDataSet.MCDB);
            // TODO: This line of code loads data into the 'bills.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.bills.Bill);
            id.Focus();
            this.bills.Bill.AddBillRow(this.bills.Bill.NewBillRow());
            billBindingSource.MoveLast();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertQuery = "INSERT INTO Bill (T_id,Movie,Price,Quantity,Total,Screen,Seat) VALUES (?,?, ?, ?, ?,?,?)";
            using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("?", id.Text);
                command.Parameters.AddWithValue("?", comboBox1.Text); // Get name from textbox
                command.Parameters.AddWithValue("?", textBox3.Text); // Get address from textbox
                command.Parameters.AddWithValue("?", textBox4.Text); // Get designation from textbox
                command.Parameters.AddWithValue("?", textBox5.Text); // Get contact from textbox
                command.Parameters.AddWithValue("?", comboBox5.Text); // Get contact from textbox
                command.Parameters.AddWithValue("?", comboBox6.Text); // Get contact from textbox

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert data.");
                }
            }
            connection.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals("") && (!textBox3.Text.Equals("")))
            {
                decimal Total = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox3.Text);
                textBox5.Text = Total.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!textBox3.Text.Equals("") && (!textBox4.Text.Equals("")))
            {
                decimal Total = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text);
                textBox5.Text = Total.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string dashline = "-------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("--------------------------------------------------------------CINEMAX THEATRE----------------------------------------------------------------------", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 170));
            e.Graphics.DrawString("Ticket id :" + id.Text, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Date :" + DateTime.Now, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Movie Name", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Screen ", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString("Seat ", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(400, 250));
            e.Graphics.DrawString("Price", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("Quantity ", new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(600, 250));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString(comboBox1.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 325));
            e.Graphics.DrawString(comboBox5.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(300, 325));
            e.Graphics.DrawString(comboBox6.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 325));

            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(500, 325));
            e.Graphics.DrawString(textBox4.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 325));

            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 500));
            e.Graphics.DrawString("Total :", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 525));
            e.Graphics.DrawString(textBox5.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 525));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Italic), Brushes.Black, new Point(25, 550));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

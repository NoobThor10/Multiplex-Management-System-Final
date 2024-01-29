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

    //This is Schedule Form naming errors are there

    public partial class schedule : Form
    {
        public schedule()
        {
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addmovieDataSet.movieDet' table. You can move, or remove it, as needed.
            this.movieDetTableAdapter.Fill(this.addmovieDataSet.movieDet);


        }

        private void addbookingbtn_Click(object sender, EventArgs e)
        {
           // addBooking book = new addBooking(); 
           // book.ShowDialog();
            AddNewSchedule addNewBookings = new AddNewSchedule();
            addNewBookings.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    dataGridView1.DataSource = movieDetBindingSource;
                }
                else
                {
                    var query = from o in this.addmovieDataSet.movieDet
                                where o.name.Contains(textBox1.Text) || o.genre.Contains(textBox1.Text) || o.timming == textBox1.Text || o.ID.Equals(textBox1.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                    dataGridView1.Visible = true;
                }
            }
        }
    }
}

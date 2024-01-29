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
    public partial class AddNewSchedule : Form
    {
        public AddNewSchedule()
        {
            InitializeComponent();
        }

        private void AddNewBookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addmovieDataSet.movieDet' table. You can move, or remove it, as needed.
            this.movieDetTableAdapter.Fill(this.addmovieDataSet.movieDet);
            movieDetBindingSource.DataSource = this.addmovieDataSet.movieDet;

            this.addmovieDataSet.movieDet.AddmovieDetRow(this.addmovieDataSet.movieDet.NewmovieDetRow());
            movieDetBindingSource.MoveLast();
        }

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

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                movieDetBindingSource.EndEdit();
                movieDetTableAdapter.Update(this.addmovieDataSet.movieDet);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                movieDetBindingSource.ResetBindings(false);
                //throw;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                MoviecomboBox.Focus();
                this.addmovieDataSet.movieDet.AddmovieDetRow(this.addmovieDataSet.movieDet.NewmovieDetRow());
                movieDetBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                movieDetBindingSource.ResetBindings(false);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            schedule schedulefrm = new schedule();
            schedulefrm.Show();
            this.Hide();
        }

    }
}

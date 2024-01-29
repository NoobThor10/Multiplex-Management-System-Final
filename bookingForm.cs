using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultiplexManagementSystem
{
    // This form is booking form
    public partial class addBooking : Form  
    {
        public addBooking()
        {
            InitializeComponent();
        }
        private void addBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.MCDB' table. You can move, or remove it, as needed.
            this.mCDBTableAdapter1.Fill(this.databaseCustandMovieDataSet.MCDB);
            mCDBBindingSource.DataSource = this.databaseCustandMovieDataSet.MCDB;
            // TODO: This line of code loads data into the 'movieCustDBDataSet.MCDB' table. You can move, or remove it, as needed.
            //this.mCDBTableAdapter.Fill(this.movieCustDBDataSet.MCDB);
            //mCDBBindingSource1.DataSource = this.movieCustDBDataSet.MCDB;

            //this.databaseCustandMovieDataSet.MCDB.AddMCDBRow(this.databaseCustandMovieDataSet.MCDB.NewMCDBRow());
           // mCDBBindingSource.MoveLast();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                NameTxtbox.Focus();
                this.databaseCustandMovieDataSet.MCDB.AddMCDBRow(this.databaseCustandMovieDataSet.MCDB.NewMCDBRow());
                mCDBBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mCDBBindingSource.ResetBindings(false);

            }


        }

        

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //
                if (!EmailTxtbox.Text.Contains("@"))
                {
                    MessageBox.Show("Email must include '@' symbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
                else
                {
                    mCDBBindingSource.EndEdit();
                    mCDBTableAdapter1.Update(this.databaseCustandMovieDataSet.MCDB);
                    panel1.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mCDBBindingSource.ResetBindings(false);
                //throw;

            }
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if 2D selected with S, G, R
            if (comboBox5.SelectedItem == "2D")
            {
                if (comboBox6.SelectedItem == "Silver")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 300;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Gold")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 450;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Recliner")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 950;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }
                }
            }
            // if 3D Selected with S,G, R catagoery
            else if (comboBox5.SelectedItem == "3D")
            {
                if (comboBox6.SelectedItem == "Silver")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 400;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Gold")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 550;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Recliner")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 1050;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }
                }
            }
            // if Imax is selected with S,G
            else if (comboBox5.SelectedItem == "Imax")
            {
                if (comboBox6.SelectedItem == "Silver")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 700;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Gold")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 1000;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Recliner")
                {
                    MessageBox.Show("Can't select recliner in Imax", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            // if 4DX selected with S,G
            else if (comboBox5.SelectedItem == "4DX")
            {
                if (comboBox6.SelectedItem == "Silver")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 500;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Gold")
                {
                    if (int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedNumber))
                    {
                        int result = selectedNumber * 700;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Invalid selection.";
                    }

                }
                //
                else if (comboBox6.SelectedItem == "Recliner")
                {
                    MessageBox.Show("Can't select recliner in 4DX", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            else
            {
                MessageBox.Show("Some thing went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewBtn_Click(object sender, EventArgs e) {
            ViewMovieDet viewMovieDet = new ViewMovieDet();
            viewMovieDet.ShowDialog();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {}

        private void SearchTxtbox_TextChanged(object sender, EventArgs e) { }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){ }

        

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label10_Click(object sender, EventArgs e){  }

        private void textBox1_TextChanged(object sender, EventArgs e){  }

        private void label8_Click(object sender, EventArgs e) { }

        private void EmailTxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

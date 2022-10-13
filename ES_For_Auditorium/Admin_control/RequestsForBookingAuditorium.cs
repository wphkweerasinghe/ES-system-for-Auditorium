using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;

namespace ES_For_Auditorium.Admin_dashbord
{
    public partial class RequestsForBookingAuditorium : Form
    {
        public void DataShow()
        {
            //Show data from table
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30";
            String select = "SELECT * FROM event";

            SqlDataAdapter adapter = new SqlDataAdapter(select, conString);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "event_Details");
            dgvEvent.DataSource = ds.Tables["event_Details"];
        }
        public RequestsForBookingAuditorium()
        {
            InitializeComponent();
            //Display data from begging
            DataShow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEvent.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvEvent.CurrentRow.Cells[1].Value.ToString();
            txtTime.Text = dgvEvent.CurrentRow.Cells[3].Value.ToString();
            txtDate.Text = dgvEvent.CurrentRow.Cells[2].Value.ToString();
            txtDuration.Text = dgvEvent.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dgvEvent.CurrentRow.Cells[8].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String time = txtTime.Text;
            String date = txtDate.Text;
            String duration = txtDuration.Text;
            String price = txtPrice.Text;
            int eventId = int.Parse(txtId.Text);
            //validate data 
            if (name == "")
            {
                MessageBox.Show("Please Enter Name ");
                txtName.Focus();
            }
            else if (date == "")
            {
                MessageBox.Show("Please Enter Date ");
                txtDate.Focus();
            }
            else if (time == "")
            {
                MessageBox.Show("Please Enter Time ");
                txtTime.Focus();
            }
            else if (duration == "")
            {
                MessageBox.Show("Please Enter Duration ");
                txtDuration.Focus();
            }
            else
            {
                if (price != "")
                {
                    try
                    {
                        //convert price into float
                        float tPrice = float.Parse(price);
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("Please enter valid Price");
                        Console.WriteLine(msg.Message);
                    }
                }
                //DB Connection
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
                //connect database
                String update = "UPDATE event SET name = '" + name + "', date = '" + date + "', time = '" + time + "', duration = '" + duration + "', price = '" + price + "' WHERE id = '"+eventId+"' ;";
                SqlCommand cmd = new SqlCommand(update, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request Updated !!!");
                }
                catch (SqlException massage)
                {
                    Console.WriteLine(massage.Message);
                    MessageBox.Show("System Error \n Database not connected");
                }
                finally
                {
                    conn.Close();
                }
                DataShow();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int eventId = int.Parse(txtId.Text);
            //DB Connection
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
            //connect database
            String insert = "UPDATE event SET is_approved_by_admin = 1 WHERE id = '" + eventId + "' ;";
            SqlCommand cmd = new SqlCommand(insert, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Request Accepted !!!");
            }
            catch (SqlException massage)
            {
                Console.WriteLine(massage.Message);
                MessageBox.Show("System Error \n Database not connected");
            }
            finally
            {
                conn.Close();
            }
            dgvEvent.ClearSelection();
            //Refresh table
            DataShow();

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            int eventId = int.Parse(txtId.Text);
            //DB Connection
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
            //connect database
            String delete = "DELETE FROM event WHERE id = '" + eventId + "' ;";
            SqlCommand cmd = new SqlCommand(delete, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Recorded Delete");
            }
            catch(Exception message)
            {
                Console.WriteLine(message.Message);
                MessageBox.Show("System error !!!  \n Please try again later");
            }
            finally
            {
                conn.Close();
            }
            DataShow();
        }
    }
}

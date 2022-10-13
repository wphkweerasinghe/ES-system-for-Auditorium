using ES_For_Auditorium.Login;
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

namespace ES_For_Auditorium.User_dashbord
{
    public partial class RequestAuditorium : Form
    {
        //get currrent user Id
        int id = int.Parse(Form_login.id);
        public RequestAuditorium()
        {
            InitializeComponent();
        }

        private void panelRequest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String eName = txtEventName.Text;
            string date = dateTimePicker.Text;
            String time = txtTime.Text;
            String duration = txtDuration.Text;
            String price = txtPrice.Text;
            //validate data 
            if(eName == null)
            {
                MessageBox.Show("Please Enter Name ");
                txtEventName.Focus();
            }
            else if (date == null)
            {
                MessageBox.Show("Please Enter Date ");
                dateTimePicker.Focus();
            }
            else if (time == null)
            {
                MessageBox.Show("Please Enter Time ");
                txtTime.Focus();
            }
            else if (duration == null)
            {
                MessageBox.Show("Please Enter Duration ");
                txtDuration.Focus();
            }
            else if (price == null)
            {
                MessageBox.Show("Please Enter Price ");
                txtPrice.Focus();
            }
            else
            {
                try
                {
                    //convert price into float
                    float tPrice = float.Parse(price); 
                }
                catch(Exception msg)
                {
                    MessageBox.Show("Please enter valid Price");
                    Console.WriteLine(msg.Message);
                }
                //connect database
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
                String insert = "INSERT INTO event (name,date,time,duration,price,user_id) VALUES ('" + eName + "','" + date + "','" + time + "','" + duration + "','" + price + "','" + id + "');";
                SqlCommand cmd = new SqlCommand(insert, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request sent");
                }
                catch(SqlException massage)
                {
                    Console.WriteLine(massage.Message);
                    MessageBox.Show("System Error \n Database not connected");
                }
                finally
                {
                    conn.Close();
                }
                txtEventName.Clear();
                txtTime.Clear();
                txtDuration.Clear();
                txtPrice.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEventName.Clear();
            txtTime.Clear();
            txtDuration.Clear();
            txtPrice.Clear();
        }
    }
}

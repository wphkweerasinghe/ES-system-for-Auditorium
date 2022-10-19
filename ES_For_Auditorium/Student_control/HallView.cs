using ES_For_Auditorium.Admin_dashbord;
using ES_For_Auditorium.User_dashbord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_For_Auditorium.Student_control
{
    public partial class HallView : Form
    {
        private int user_id = int.Parse(Login.Form_login.id);
        private int event_id = EventCalender_Student.event_id;
        public HallView()
        {
            InitializeComponent();
            DisableReservedSeat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeatReserve(5);
        }

        //create a fuction for reserve a seat
        private void SeatReserve(int seat_no)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to reserve this Seat", "Buy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //connect DB
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Lectuers\\2nd year\\2nd semester\\ES\\Final assigement\\AuditoriumReservationDB.mdf\';Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("INSERT INTO reservation (event_id, user_id, seat_no) VALUES ('" + event_id + "', '" + user_id + "', '" + seat_no + "');", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seat Reserved successfully");
                }
                catch (SqlException msg)
                {
                    MessageBox.Show("Connection Error ! \n Please try again later");
                    Console.WriteLine(msg.Message);
                }
                finally
                {
                    con.Close();
                }
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //here
            }
        }

        //create function to disable reserved seats's button
        private void DisableReservedSeat()
        {
            //get reserved seat numbers from the database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Lectuers\\2nd year\\2nd semester\\ES\\Final assigement\\AuditoriumReservationDB.mdf\';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT seat_no FROM reservation WHERE user_id = '"+user_id+"' AND event_id = '"+event_id+"' ;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            //create array to save seat numbers
            List<int> reservedSeatNo = new List<int>();
            //get reserved seat numbers to array
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reservedSeatNo.Add((int)dt.Rows[i]["seat_no"]);
            }
            //check seats
            foreach (int seatNo in reservedSeatNo)
            {
                for(int i = 0; i < reservedSeatNo.Count; i++)
                {
                    if(reservedSeatNo[i] == seatNo)
                    {
                        //set button disabled 
                        this.Controls.Find("btn" + seatNo.ToString(), true).FirstOrDefault().Enabled = false;
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SeatReserve(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SeatReserve(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SeatReserve(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SeatReserve(4);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SeatReserve(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SeatReserve(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SeatReserve(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SeatReserve(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            SeatReserve(10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            SeatReserve(11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            SeatReserve(12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            SeatReserve(13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            SeatReserve(14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            SeatReserve(15);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            SeatReserve(16);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            SeatReserve(17);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            SeatReserve(18);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            SeatReserve(19);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            SeatReserve(20);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            SeatReserve(21);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            SeatReserve(22);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            SeatReserve(23);
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            SeatReserve(24);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            SeatReserve(25);
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            SeatReserve(26);
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            SeatReserve(27);
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            SeatReserve(28);
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            SeatReserve(29);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            SeatReserve(30);
        }
    }
}

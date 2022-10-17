using ES_For_Auditorium.Admin_control;
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
using System.Xml.Linq;

namespace ES_For_Auditorium.Admin_dashbord
{
    public partial class EventCalender : Form
    {
        public EventCalender()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EventRow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventCalender_Load(object sender, EventArgs e)
        {
            EventLoad();
        }
        //Create function to load events
        private void EventLoad()
        {
            EventList eventList = new EventList();
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Lectuers\\2nd year\\2nd semester\\ES\\Final assigement\\AuditoriumReservationDB.mdf\';Integrated Security=True;Connect Timeout=30"))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM event WHERE is_approved_by_admin = 1 AND is_approved_by_MIC = 1 AND is_approved_by_manager = 1;", con))
            {
                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())

                        while (reader.HasRows)
                        {
                            
                                while (reader.Read())
                                {
                                    eventList.Title = reader["name"].ToString();
                                    eventList.Time = reader["time"].ToString();
                                    eventList.Date = reader["date"].ToString();
                                    eventList.Price = reader["price"].ToString(); 
                                }
                            if(flowLayoutPanel1.Controls.Count < 0)
                            {
                                flowLayoutPanel1.Controls.Clear();
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(eventList);
                            }
                            reader.NextResult();
                        }

                }
                catch (SqlException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}

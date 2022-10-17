using ES_For_Auditorium.Admin_control;
using ES_For_Auditorium.Properties;
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

namespace ES_For_Auditorium.User_dashbord
{
    public partial class EventCalender : Form
    {
        public EventCalender()
        {
            InitializeComponent();
        }

        private void EventCalender_Load(object sender, EventArgs e)
        {
            EventLoadStudentView();
        }
        //Create function to load events
        private void EventLoadStudentView()
        {
            //Clear flowLayoutPanle
            flowLayoutPanel.Controls.Clear();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Lectuers\\2nd year\\2nd semester\\ES\\Final assigement\\AuditoriumReservationDB.mdf\';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT * FROM event WHERE is_approved_by_admin = 1 AND is_approved_by_MIC = 1 AND is_approved_by_manager = 1;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //create object
                EventList eventList = new EventList();

                eventList.Title = dt.Rows[i][1].ToString();
                eventList.Time = dt.Rows[i][3].ToString();
                eventList.Date = dt.Rows[i][2].ToString();
                eventList.Price = dt.Rows[i][8].ToString();
                eventList.Icon = Resources.nsbm_logo_favicon;
                eventList.IconBackColor = Color.Silver;

                Console.WriteLine("Data");

                flowLayoutPanel.Controls.Add(eventList);
                Console.WriteLine("add object");
            }
        }
    }
}

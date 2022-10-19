using ES_For_Auditorium.Admin_control;
using ES_For_Auditorium.Properties;
using ES_For_Auditorium.Student_control;
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
    public partial class EventCalender_Student : Form
    {
        public static int event_id; 
        public EventCalender_Student()
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
            //create object
            EventList[] eventList = new EventList[100];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                eventList[i] = new EventList();

                eventList[i].Id = dt.Rows[i][0].ToString();
                eventList[i].Title = dt.Rows[i][1].ToString();
                eventList[i].Time = dt.Rows[i][3].ToString();
                eventList[i].Date = dt.Rows[i][2].ToString();
                eventList[i].Price = dt.Rows[i][8].ToString();
                eventList[i].Icon = Resources.nsbm_logo_favicon;
                eventList[i].IconBackColor = Color.Silver;

                flowLayoutPanel.Controls.Add(eventList[i]);
                //create click event
                eventList[i].Click += new System.EventHandler(this.EventList_Click);
                Console.WriteLine(eventList[i].Id);
            }
        }
        public void EventList_Click(object sender, EventArgs e)
        {
            //create object to access values 
            EventList obj = (EventList)sender;
            event_id = int.Parse(obj.Id);

            //Open Hall View form
            HallView frm = new HallView();
            frm.Show();
        }

        private void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.White;
        }

        private void flowLayoutPanel_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

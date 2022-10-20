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
using System.Xml.Linq;

namespace ES_For_Auditorium.Admin_dashbord
{
    public partial class EventCalender : Form
    {
        int event_id = 0;
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
            //Clear flowLayoutPanle
            flowLayoutPanel1.Controls.Clear();
          
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Lectuers\\2nd year\\2nd semester\\ES\\Final assigement\\AuditoriumReservationDB.mdf\';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT * FROM event WHERE is_approved_by_admin = 1 AND is_approved_by_MIC = 1 AND is_approved_by_manager = 1;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

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

                flowLayoutPanel1.Controls.Add(eventList[i]);
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

            DialogResult dialogResult = MessageBox.Show("Are you want Delete this event from Schedule", "Drop", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteEvent(event_id);
            }
            else
            {
                Console.WriteLine("Canceled delete");
            }
            EventLoad();
        }
        public void DeleteEvent(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\'D:\\Lectuers\\2nd year\\2nd semester\\ES\\Final assigement\\AuditoriumReservationDB.mdf\';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("DELETE FROM event WHERE id = '"+event_id+"';", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event Deleted !!!");
            }
            catch(SqlException msg)
            {
                MessageBox.Show("System Error \n Please Try agian later");
                Console.WriteLine(msg.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void panelEventList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

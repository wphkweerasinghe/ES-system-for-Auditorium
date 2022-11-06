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

namespace ES_For_Auditorium.Admin_dashbord
{
    public partial class AcceptedRequests : Form
    {
        public AcceptedRequests()
        {
            InitializeComponent();
            //Show data from table
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30";
            String select = "SELECT event.name, event.date, event.time, event.duration, event.is_approved_by_admin, event.is_approved_by_mic, event.is_approved_by_manager, event.price, users.username FROM event FULL OUTER JOIN users ON event.user_id = users.id WHERE is_approved_by_admin = 1 AND is_approved_by_mic = 1 AND is_approved_by_manager = 1 ;";

            SqlDataAdapter adapter = new SqlDataAdapter(select, conString);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "event_Details");
            dgvAccepted.DataSource = ds.Tables["event_Details"];
        }

        private void AcceptedRequests_Load(object sender, EventArgs e)
        {

        }
    }
}
